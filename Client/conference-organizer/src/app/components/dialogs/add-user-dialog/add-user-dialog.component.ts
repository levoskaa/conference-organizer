import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { AddUserDialogData } from '@models/AddUserDialogData';
import { CreateUserDto } from '@models/generated';
import { tap } from 'rxjs/operators';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { UsersService } from 'src/app/services/users.service';

@Component({
    selector: 'app-add-user-dialog',
    templateUrl: './add-user-dialog.component.html',
    styleUrls: ['./add-user-dialog.component.scss']
})
export class AddUserDialogComponent extends UnsubscribeOnDestroy implements OnInit {

    formControls: Record<keyof CreateUserDto, FormControl> = {
        username: new FormControl(null, Validators.required),
        password: new FormControl(null, Validators.required),
    };
    form = new FormGroup(this.formControls);
    public data: AddUserDialogData = new AddUserDialogData();

    constructor(
        public dialogRef: MatDialogRef<AddUserDialogComponent>,
        private readonly usersService: UsersService
    ) {
        super();
    }

    ngOnInit(): void {

    }

    submit(): void {
        const dto = this.form.value;
        this.subscribe(this.usersService.addUser(dto).pipe(
            tap(() => this.dialogRef.close({ isSuccessful: true }))
        ));
    }

    cancel(): void {
        this.dialogRef.close({ isSuccessful: false });
    }
}
