import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ProfessionalFieldUpdateDto, ProfessionalFieldViewModel, UserViewModel } from '@models/generated';
import { combineLatest } from 'rxjs';
import { map, switchMap, tap } from 'rxjs/operators';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { FieldsService } from 'src/app/services/fields.service';
import { UsersService } from 'src/app/services/users.service';

@Component({
    selector: 'app-add-field-to-user-dialog',
    templateUrl: './add-field-to-user-dialog.component.html',
    styleUrls: ['./add-field-to-user-dialog.component.scss']
})
export class AddFieldToUserDialogComponent extends UnsubscribeOnDestroy implements OnInit {
    fields: ProfessionalFieldViewModel[] = [];
    user: UserViewModel;

    formControls = {
        fieldIds: new FormControl(null, Validators.required),
    }
    form = new FormGroup(this.formControls);

    constructor(
        @Inject(MAT_DIALOG_DATA) private readonly userId: number,
        private readonly dialogRef: MatDialogRef<AddFieldToUserDialogComponent>,
        private readonly usersService: UsersService,
        private readonly fieldsService: FieldsService,
    ) {
        super();
    }

    ngOnInit(): void {
        this.subscribe(this.usersService.getCurrentUser().pipe(
            tap((user) => {
                this.user = user;
            })
        ));

        this.subscribe(this.fieldsService.getFields().pipe(
            map((response) => response.professionalFields),
            tap((fields) => this.fields = fields),
        ));

    }

    submit(): void {
        const dto: ProfessionalFieldUpdateDto = {
            professionalFieldIds: this.formControls.fieldIds.value,
        }
        this.subscribe(this.usersService.addUserField(dto).pipe(
            tap(() => this.dialogRef.close({ isSuccessful: true }))
        ));
    }

    cancel(): void {
        this.dialogRef.close({ isSuccessful: false });
    }

}
