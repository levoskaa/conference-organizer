import { Component, Inject, OnInit } from '@angular/core';
import { MatDialog, MatDialogConfig, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { CreateUserDto, UserViewModel } from '@models/generated';
import { ToastrService } from 'ngx-toastr';
import { filter, map, tap } from 'rxjs/operators';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { DialogService } from 'src/app/services/dialog.service';
import { UsersService } from 'src/app/services/users.service';
import { AddUserDialogComponent } from '../dialogs/add-user-dialog/add-user-dialog.component';
import { TableColumn } from '../table/table.models';

@Component({
    selector: 'app-users-page',
    templateUrl: './users-page.component.html',
    styleUrls: ['./users-page.component.scss']
})
export class UsersPageComponent extends UnsubscribeOnDestroy implements OnInit {
    readonly columns: TableColumn[] = [{
        name: 'Név',
        dataField: 'username',
    },
    {
        name: 'Szerep',
        dataField: 'role',
    }];
    users: UserViewModel[];

    constructor(private readonly usersService: UsersService,
        private readonly router: Router,
        private dialog: MatDialog,
        private toast: ToastrService,
        private readonly dialogService: DialogService,) {
        super();
    }

    ngOnInit(): void {
        this.getData();
    }

    private getData(): void {
        this.subscribe(this.usersService.getUsers().pipe(
            map(response => response.users),
            tap(users => this.users = users)
        ));
    }

    addUserClick(): void {
        const dialogRef = this.dialogService.openDialog(AddUserDialogComponent);
        this.subscribe(dialogRef.afterClosed().pipe(
            filter((result) => !!result?.isSuccessful),
            tap(() => {
                this.getData();
                this.toast.success('Felhasználó sikeresen hozzáadva.');
            }),
        ));
    }

    onUserClicked(userViewModel: UserViewModel): void {
        this.router.navigate(['/users', userViewModel.id]);
    }
}
