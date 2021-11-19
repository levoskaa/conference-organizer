import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AppHttpClient } from '../core/app-http-client';
import { ConferencesViewModel } from '../models/generated';

@Injectable({
    providedIn: 'root'
})
export class ConferencesService {
    private readonly conferencesApiUrl = 'api/conferences';

    constructor(private readonly httpClient: AppHttpClient) { }

    getConferences(): Observable<ConferencesViewModel> {
        return this.httpClient.get<ConferencesViewModel>(`${this.conferencesApiUrl}`);
    }
}
