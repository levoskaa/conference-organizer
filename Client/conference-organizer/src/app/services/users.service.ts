import { Injectable } from '@angular/core';
import { UsersViewModel, UserViewModel } from '@models/generated';
import { Observable } from 'rxjs';
import { AppHttpClient } from '../core/app-http-client';

@Injectable({
    providedIn: 'root'
})
export class UsersService {
    private readonly usersApiUrl = 'api/users';

    constructor(private readonly httpClient: AppHttpClient) { }

    getCurrentUser(): Observable<UserViewModel> {
        return this.httpClient.get<UserViewModel>(`${this.usersApiUrl}/me`);
    }

    getUsers(): Observable<UsersViewModel> {
        return this.httpClient.get<UsersViewModel>(`${this.usersApiUrl}`);
    }
}
