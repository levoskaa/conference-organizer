import { Injectable } from '@angular/core';
import { RoomsViewModel, RoomUpsertDto } from '@models/generated';
import { Observable } from 'rxjs';
import { AppHttpClient } from '../core/app-http-client';

@Injectable({
    providedIn: 'root'
})
export class RoomService {
    private readonly roomsApiUrl = 'api/rooms';

    constructor(private readonly httpClient: AppHttpClient) { }

    getRooms(): Observable<RoomsViewModel> {
        return this.httpClient.get(`${this.roomsApiUrl}`);
    }

    addRoom(dto: RoomUpsertDto): Observable<RoomUpsertDto> {
        return this.httpClient.post<RoomUpsertDto>(`${this.roomsApiUrl}`, dto);
    }
}
