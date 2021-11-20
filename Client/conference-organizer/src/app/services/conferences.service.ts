import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AppHttpClient } from '../core/app-http-client';
import { ConferencesViewModel, ConferenceUpsertDto, ConferenceViewModel, SectionsViewModel } from '../models/generated';

@Injectable({
    providedIn: 'root'
})
export class ConferencesService {
    private readonly conferencesApiUrl = 'api/conferences';

    constructor(private readonly httpClient: AppHttpClient) { }

    getConferences(): Observable<ConferencesViewModel> {
        return this.httpClient.get<ConferencesViewModel>(`${this.conferencesApiUrl}`);
    }

    getConference(conferenceId: number): Observable<ConferenceViewModel> {
        return this.httpClient.get<ConferenceViewModel>(`${this.conferencesApiUrl}/${conferenceId}`);
    }

    getConferenceSections(conferenceId: number): Observable<SectionsViewModel> {
        return this.httpClient.get<SectionsViewModel>(`${this.conferencesApiUrl}/${conferenceId}/sections`);
    }

    updateConference(conferenceId: number, dto: ConferenceUpsertDto): Observable<void> {
        return this.httpClient.put<void>(`${this.conferencesApiUrl}/${conferenceId}`, dto);
    }
}
