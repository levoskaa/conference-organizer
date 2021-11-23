import { Injectable } from '@angular/core';
import { ProfessionalFieldsViewModel, ProfessionalFieldUpsertDto } from '@models/generated';
import { Observable } from 'rxjs';
import { AppHttpClient } from '../core/app-http-client';

@Injectable({
    providedIn: 'root'
})
export class FieldsService {
    private readonly fieldsApiUrl = 'api/professionalfields';

    constructor(private readonly httpClient: AppHttpClient) { }

    getFields(): Observable<ProfessionalFieldsViewModel> {
        return this.httpClient.get(`${this.fieldsApiUrl}`);
    }

    addField(dto: ProfessionalFieldUpsertDto): Observable<ProfessionalFieldUpsertDto> {
        return this.httpClient.post<ProfessionalFieldUpsertDto>(`${this.fieldsApiUrl}`, dto);
    }
}
