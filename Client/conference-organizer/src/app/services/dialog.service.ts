import { ComponentType } from '@angular/cdk/overlay';
import { Injectable } from '@angular/core';
import { MatDialog, MatDialogConfig, MatDialogRef } from '@angular/material/dialog';
import { DialogResult } from '@models/dialog';

@Injectable({
    providedIn: 'root'
})
export class DialogService {

    constructor(private readonly dialog: MatDialog) { }

    openDialog<T>(component: ComponentType<T>, data?: any): MatDialogRef<T, DialogResult> {
        const config = {
            autoFocus: true,
            hasBackdrop: true,
            closeOnNavigation: true,
            disableClose: true,
            width: '450px',
            data
        };
        const dialogRef = this.dialog.open(
            component,
            config
        );
        return dialogRef;
    }
}
