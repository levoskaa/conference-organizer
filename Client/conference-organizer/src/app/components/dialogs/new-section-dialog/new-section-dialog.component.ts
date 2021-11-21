import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { ProfessionalFieldViewModel, RoomViewModel, SectionUpsertDto, UserViewModel } from '@models/generated';
import { map, switchMap, tap } from 'rxjs/operators';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { ConferencesService } from 'src/app/services/conferences.service';
import { RoomService } from 'src/app/services/room.service';
import { UsersService } from 'src/app/services/users.service';

@Component({
    selector: 'app-new-section-dialog',
    templateUrl: './new-section-dialog.component.html',
})
export class NewSectionDialogComponent extends UnsubscribeOnDestroy implements OnInit {
    rooms: RoomViewModel[] = [];
    users: UserViewModel[] = [];
    userFields: ProfessionalFieldViewModel[] = [];

    formControls: Record<keyof SectionUpsertDto, FormControl> = {
        beginDate: new FormControl(null, Validators.required),
        endDate: new FormControl(null, Validators.required),
        roomId: new FormControl(null, Validators.required),
        chairmanId: new FormControl(null, Validators.required),
        fieldId: new FormControl(null, Validators.required),
    };
    form = new FormGroup(this.formControls);

    constructor(
        @Inject(MAT_DIALOG_DATA) private readonly conferenceId: number,
        private readonly dialogRef: MatDialogRef<NewSectionDialogComponent>,
        private readonly conferenceService: ConferencesService,
        private readonly roomService: RoomService,
        private readonly usersService: UsersService,
    ) {
        super();
    }

    ngOnInit(): void {
        this.subscribe(this.roomService.getRooms().pipe(
            map((response) => response.rooms),
            tap((rooms) => this.rooms = rooms),
        ));
        this.subscribe(this.usersService.getUsers().pipe(
            map((response) => response.users),
            tap((users) => this.users = users),
        ));
        this.subscribe(this.formControls.chairmanId.valueChanges.pipe(
            switchMap((userId) => this.usersService.getUserFields(userId)),
            map((response) => response.professionalFields),
            tap((userFields) => this.userFields = userFields),
        ));
    }

    submit(): void {
        const dto = this.form.value;
        this.subscribe(this.conferenceService.addSection(this.conferenceId, dto).pipe(
            tap(() => this.dialogRef.close({ isSuccessful: true }))
        ));
    }

    cancel(): void {
        this.dialogRef.close({ isSuccessful: false });
    }
}
