import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { AddUserDialogData } from '@models/AddUserDialogData';
import { CreateUserDto } from '@models/generated';

@Component({
    selector: 'app-add-user-dialog',
    templateUrl: './add-user-dialog.component.html',
    styleUrls: ['./add-user-dialog.component.scss']
})
export class AddUserDialogComponent implements OnInit {

    addUserForm: FormGroup;
    public data: AddUserDialogData = new AddUserDialogData();

    constructor(public dialogRef: MatDialogRef<AddUserDialogComponent>,
        private formBuilder: FormBuilder) {
    }

    ngOnInit(): void {
        this.addUserForm = this.formBuilder.group({
            username: [null, [Validators.required]],
            password: [null, [Validators.required]]
        });

        this.addUserForm.get('username')?.valueChanges.subscribe((name) => {
            this.data.username = name;
        })

        this.addUserForm.get('password')?.valueChanges.subscribe((password) => {
            this.data.password = password;
        })
    }

    onNoClick(): void {
        this.dialogRef.close();
    }
}
