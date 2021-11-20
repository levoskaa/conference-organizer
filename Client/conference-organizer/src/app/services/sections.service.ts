import { Injectable } from '@angular/core';
import { SectionViewModel } from '@models/generated';
import { Observable } from 'rxjs';
import { AppHttpClient } from '../core/app-http-client';

@Injectable({
    providedIn: 'root'
})
export class SectionsService {
    private readonly sectionsApiUrl = 'api/sections';

    constructor(private readonly httpClient: AppHttpClient) { }

    getSection(sectionId: number): Observable<SectionViewModel> {
        return this.httpClient.get<SectionViewModel>(`${this.sectionsApiUrl}/${sectionId}`);
    }
}
