import { Injectable } from '@angular/core';
import { ConferenceViewModel, EntityCreatedViewModel, PresentationsViewModel, PresentationUpsertDto, ProfessionalFieldViewModel, RoomViewModel, SectionUpsertDto, SectionViewModel, UserViewModel } from '@models/generated';
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

    getSectionField(sectionId: number): Observable<ProfessionalFieldViewModel> {
        return this.httpClient.get<ProfessionalFieldViewModel>(`${this.sectionsApiUrl}/${sectionId}/field`);
    }

    getSectionChairman(sectionId: number): Observable<UserViewModel> {
        return this.httpClient.get<UserViewModel>(`${this.sectionsApiUrl}/${sectionId}/chairman`);
    }

    getSectionRoom(sectionId: number): Observable<RoomViewModel> {
        return this.httpClient.get<RoomViewModel>(`${this.sectionsApiUrl}/${sectionId}/room`);
    }

    getSectionConference(sectionId: number): Observable<ConferenceViewModel> {
        return this.httpClient.get<ConferenceViewModel>(`${this.sectionsApiUrl}/${sectionId}/conference`);
    }

    updateSection(sectionId: number, dto: SectionUpsertDto): Observable<void> {
        return this.httpClient.put(`${this.sectionsApiUrl}/${sectionId}`, dto);
    }

    addPresentation(sectionId: number, dto: PresentationUpsertDto): Observable<EntityCreatedViewModel> {
        return this.httpClient.post<EntityCreatedViewModel>(`${this.sectionsApiUrl}/${sectionId}/presentations`, dto);
    }

    addPresentationByFile(sectionId: number, formData: FormData): Observable<EntityCreatedViewModel> {
        return this.httpClient.post<EntityCreatedViewModel>(`${this.sectionsApiUrl}/${sectionId}/presentations/file`, formData);
    }

    deleteSection(sectionId: number): Observable<void> {
        return this.httpClient.delete(`${this.sectionsApiUrl}/${sectionId}`);
    }
}
