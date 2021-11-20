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

export interface PresentationViewModel {
    id: number;
    presenter: string;
    title: string;
}

export interface PresentationsViewModel {
    presentations: PresentationViewModel[];
}

export interface CreateUserDto {
    username: string;
    password: string;
}

export interface ProfessionalFieldUpdateDto {
    professionalFieldIds: number[];
}

export enum Role {
    User = 'User',
    Admin = 'Admin',
}

export interface UserViewModel {
    username: string;
    role: Role;
    editableConferenceIds: number[];
}

export interface UsersViewModel {
    users: UserViewModel[];
}