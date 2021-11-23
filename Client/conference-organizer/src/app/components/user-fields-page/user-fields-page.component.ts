import { Component, OnInit } from '@angular/core';
import { ProfessionalFieldViewModel, UserViewModel } from '@models/generated';
import { filter, map, switchMap, tap } from 'rxjs/operators';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { DialogService } from 'src/app/services/dialog.service';
import { UsersService } from 'src/app/services/users.service';
import { AddFieldToUserDialogComponent } from '../dialogs/add-field-to-user-dialog/add-field-to-user-dialog.component';
import { TableColumn } from '../table/table.models';

@Component({
    selector: 'app-user-fields-page',
    templateUrl: './user-fields-page.component.html',
    styleUrls: ['./user-fields-page.component.scss']
})
export class UserFieldsPageComponent extends UnsubscribeOnDestroy implements OnInit {
    user: UserViewModel | undefined;
    userFields: ProfessionalFieldViewModel[];

    readonly userFieldColumns: TableColumn[] = [
        {
            name: 'Téma',
            dataField: 'name',
        },
    ];

    constructor(
        private readonly usersService: UsersService,
        private readonly dialogService: DialogService,
    ) {
        super();
    }

    ngOnInit(): void {
        this.getData();
    }

    getData() {
        const user$ = this.usersService.getCurrentUser().pipe(
            tap((user) => {
                this.user = user;
            })
        );
        this.subscribe(user$.pipe(
            switchMap((user) => this.usersService.getUserFields(user.id)),
            map((response) => response.professionalFields),
            tap((fields) => {
                this.userFields = fields;
            })
        ));
    }

    chooseUserFields() {
        const dialogRef = this.dialogService.openDialog(AddFieldToUserDialogComponent, this.user?.id);
        this.subscribe(dialogRef.afterClosed().pipe(
            filter((result) => !!result?.isSuccessful),
            tap(() => this.getData()),
        ));
    }

}
