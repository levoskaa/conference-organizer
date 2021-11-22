import { Injectable } from '@angular/core';
import { EntityCreatedViewModel, PresentationsViewModel, PresentationUpsertDto, SectionUpsertDto, SectionViewModel } from '@models/generated';
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

    getSectionPresentations(sectionId: number): Observable<PresentationsViewModel> {
        return this.httpClient.get<PresentationsViewModel>(`${this.sectionsApiUrl}/${sectionId}/presentations`);
    }

    updateSection(sectionId: number, dto: SectionUpsertDto): Observable<void> {
        return this.httpClient.put(`${this.sectionsApiUrl}/${sectionId}`, dto);
    }

    addPresentation(sectionId: number, dto: PresentationUpsertDto): Observable<EntityCreatedViewModel> {
        return this.httpClient.post<EntityCreatedViewModel>(`${this.sectionsApiUrl}/${sectionId}/presentations`, dto);
    }

    deleteSection(sectionId: number): Observable<void> {
        return this.httpClient.delete(`${this.sectionsApiUrl}/${sectionId}`);
    }
}
