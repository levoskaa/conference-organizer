import { CreateUserDto } from "./generated";

export class AddUserDialogData implements CreateUserDto {
    username: string;
    password: string;
}