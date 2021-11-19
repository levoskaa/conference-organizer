import { Component, Inject, OnInit } from '@angular/core';
import { MatDialog, MatDialogConfig, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { CreateUserDto, UserViewModel } from '@models/generated';
import { map, tap } from 'rxjs/operators';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
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
        private dialog: MatDialog) {
        super();
    }

    ngOnInit(): void {
        this.subscribe(this.usersService.getUsers().pipe(
            map(response => response.users),
            tap(users => this.users = users)
        ));
    }

    addUserClick() {
        const dialogConfig = this.setAddUserDialogConfigs();
        const dialogRef = this.dialog.open(
            AddUserDialogComponent,
            dialogConfig
        );
        dialogRef.afterClosed().subscribe((result: CreateUserDto) => {
            if (result) {
                this.usersService.addUser(result).subscribe((result) => console.log(result));
            }
        });
    }

    setAddUserDialogConfigs(): MatDialogConfig {
        const dialogConfig = new MatDialogConfig();
        dialogConfig.autoFocus = true;
        dialogConfig.hasBackdrop = true;
        dialogConfig.closeOnNavigation = true;
        dialogConfig.disableClose = true;
        dialogConfig.width = '450px';

        return dialogConfig;
    }
}
