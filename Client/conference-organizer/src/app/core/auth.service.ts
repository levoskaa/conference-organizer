import { Injectable, Output } from '@angular/core';
import { BehaviorSubject, Observable, Subject } from 'rxjs';
import { tap } from 'rxjs/operators';
import { LoginDto, Role, TokenViewModel, UserViewModel } from '../models/generated';
import { UsersService } from '../services/users.service';
import { AppHttpClient } from './app-http-client';

@Injectable({
    providedIn: 'root'
})
export class AuthService {
    private readonly authUrl = 'api/auth';

    private currentUserSubject: BehaviorSubject<UserViewModel | null>;
    public currentUser: Observable<UserViewModel | null>;

    constructor(private readonly httpClient: AppHttpClient, private readonly usersService: UsersService) {
        if (this.getAccessToken() !== null) {
            const userViewModel: UserViewModel = {
                username: '',
                role: this.isAdminFromToken() ? Role.Admin : Role.User,
                editableConferenceIds: []
            }
            this.currentUserSubject = new BehaviorSubject<UserViewModel | null>(userViewModel);
        }
        else {
            this.currentUserSubject = new BehaviorSubject<UserViewModel | null>(null);
        }

        this.currentUser = this.currentUserSubject.asObservable();
    }

    public get currentUserValue(): UserViewModel | null {
        return this.currentUserSubject.value;
    }

    login(loginDto: LoginDto): Observable<TokenViewModel> {
        return this.httpClient.post<TokenViewModel>(`${this.authUrl}/login`, loginDto).pipe(
            tap((response) => {
                this.setSession(response);
                const userViewModel: UserViewModel = {
                    username: '',
                    role: this.isAdminFromToken() ? Role.Admin : Role.User,
                    editableConferenceIds: []
                }
                this.currentUserSubject.next(userViewModel);
            }));
    }

    logout(): void {
        this.removeSession();
        this.currentUserSubject.next(null);
    }

    private setSession(tokenViewModel: TokenViewModel): void {
        localStorage.setItem('access_token', tokenViewModel.accessToken);
    }

    private removeSession(): void {
        localStorage.removeItem("access_token");
    }

    getAccessToken(): string | null {
        return localStorage.getItem("access_token");
    }

    isAdminFromToken(): boolean {
        let jwt = localStorage.getItem('access_token');

        if (jwt !== null) {
            let jwtData = jwt.split('.')[1]
            let decodedJwtJsonData = window.atob(jwtData)
            let decodedJwtData = JSON.parse(decodedJwtJsonData)

            if (decodedJwtData['http://schemas.microsoft.com/ws/2008/06/identity/claims/role'] === "Admin") {
                return true;
            }
        }

        return false;
    }

}
