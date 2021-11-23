import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { ConferenceUpsertDto, Role, UserViewModel } from '@models/generated';
import { map, tap } from 'rxjs/operators';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { ConferencesService } from 'src/app/services/conferences.service';
import { UsersService } from 'src/app/services/users.service';

@Component({
    selector: 'app-new-conference-dialog',
    templateUrl: './new-conference-dialog.component.html',
    styleUrls: ['./new-conference-dialog.component.scss']
})
export class NewConferenceDialogComponent extends UnsubscribeOnDestroy implements OnInit {

    formControls = {
        name: new FormControl(null, Validators.required),
        dateRange: new FormGroup({
            start: new FormControl(null, Validators.required),
            end: new FormControl(null, Validators.required),
        }),
        editors: new FormControl(null),
    }
    form = new FormGroup(this.formControls);
    users: UserViewModel[];

    constructor(
        private dialogRef: MatDialogRef<NewConferenceDialogComponent>,
        private readonly conferencesService: ConferencesService,
        private readonly usersService: UsersService,
    ) {
        super();
    }

    ngOnInit(): void {
        this.subscribe(this.usersService.getUsers().pipe(
            map((response) => response.users.filter((user) => user.role !== Role.Admin)),
            tap((users) => this.users = users)
        ));
    }

    submit(): void {
        const dto: ConferenceUpsertDto = {
            name: this.formControls.name.value,
            beginDate: this.formControls.dateRange.controls.start.value,
            endDate: this.formControls.dateRange.controls.end.value,
            editors: this.formControls.editors.value ? this.formControls.editors.value : [],
        };
        this.subscribe(this.conferencesService.addConference(dto).pipe(
            tap(() => this.dialogRef.close({ isSuccessful: true }))
        ));
    }

    cancel(): void {
        this.dialogRef.close({ isSuccessful: false });
    }


}
