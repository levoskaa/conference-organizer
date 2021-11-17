import { Injectable, Output } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import { tap } from 'rxjs/operators';
import { LoginDto, TokenViewModel } from '../models/generated';
import { AppHttpClient } from './app-http-client';

@Injectable({
    providedIn: 'root'
})
export class AuthService {
    private readonly authUrl = 'api/auth';

    @Output() userLoggedIn: Subject<boolean> = new Subject();
    @Output() adminLoggedIn: Subject<boolean> = new Subject();

    constructor(private readonly httpClient: AppHttpClient) { }

    login(loginDto: LoginDto): Observable<TokenViewModel> {
        return this.httpClient.post<TokenViewModel>(`${this.authUrl}/login`, loginDto).pipe(
            tap((response) => this.setSession(response)),
            tap(() => this.userLoggedin()));
    }

    private setSession(tokenViewModel: TokenViewModel): void {
        localStorage.setItem('access_token', tokenViewModel.accessToken);
    }

    logout(): void {
        this.removeSession();
        this.userLoggedout();
        this.adminLoggedout();
    }

    private removeSession(): void {
        localStorage.removeItem("access_token");
    }

    getAccessToken(): string | null {
        return localStorage.getItem("access_token");
    }

    userLoggedin() {
        this.userLoggedIn.next(true);
    }

    adminLoggedin() {
        this.adminLoggedIn.next(true);
    }

    userLoggedout() {
        this.userLoggedIn.next(false);
    }

    adminLoggedout() {
        this.adminLoggedIn.next(false);
    }

}
