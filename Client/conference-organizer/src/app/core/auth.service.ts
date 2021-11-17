import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { LoginDto, TokenViewModel } from '../models/generated';
import { AppHttpClient } from './app-http-client';

@Injectable({
    providedIn: 'root'
})
export class AuthService {
    private readonly authUrl = 'api/auth';

    constructor(private readonly httpClient: AppHttpClient) { }

    login(loginDto: LoginDto): Observable<TokenViewModel> {
        return this.httpClient.post<TokenViewModel>(`${this.authUrl}/login`, loginDto).pipe(
            tap((response) => this.setSession(response))
        );
    }

    private setSession(tokenViewModel: TokenViewModel): void {
        localStorage.setItem('access_token', tokenViewModel.accessToken);
    }

    logout(): void {
        this.removeSession();
    }

    private removeSession(): void {
        localStorage.removeItem("access_token");
    }

    getAccessToken(): string | null {
        return localStorage.getItem("access_token");
    }
}
