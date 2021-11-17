export interface LoginDto {
    username: string;
    password: string;
}

export interface TokenViewModel {
    accessToken: string;
}

export interface ConferenceUpsertDto {
    name: string;
    beginDate: Date;
    endDate: Date;
    editors: number[];
}

export interface EntityCreatedViewModel {
    id: number;
}

export interface ConferenceViewModel {
    id: number;
    name: string;
    beginDate: Date;
    endDate: Date;
}

export interface ConferencesViewModel {
    conferences: ConferenceViewModel[];
}

export interface SectionViewModel {
    id: number;
    beginDate: Date;
    endDate: Date;
    room: string;
    chairman: string;
    field: string;
}

export interface SectionsViewModel {
    sections: SectionViewModel[];
}

export interface SectionUpsertDto {
    beginDate: Date;
    endDate: Date;
    roomId: number;
    chairmanId: number;
    fieldId: number;
}

export interface ProfessionalFieldUpsertDto {
    name: string;
}

export interface ProfessionalFieldViewModel {
    id: number;
    name: string;
}

export interface ProfessionalFieldsViewModel {
    professionalFields: ProfessionalFieldViewModel[];
}

export interface RoomUpsertDto {
    uniqueName: string;
    capacity: number;
}

export interface RoomViewModel {
    id: number;
    uniqueName: string;
    capacity: number;
}

export interface RoomsViewModel {
    rooms: RoomViewModel[];
}

export interface PresentationUpsertDto {
    presenter: string;
    title: string;
}

export interface PresentationsUpsertDto {
    presentations: PresentationUpsertDto[];
}

export interface CreateUserDto {
    username: string;
    password: string;
}

export interface ProfessionalFieldUpdateDto {
    professionalFieldIds: number[];
}