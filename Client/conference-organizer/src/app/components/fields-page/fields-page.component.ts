import { Component, OnInit } from '@angular/core';
import { ProfessionalFieldViewModel, Role, UserViewModel } from '@models/generated';
import { ToastrService } from 'ngx-toastr';
import { filter, map, tap } from 'rxjs/operators';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { DialogService } from 'src/app/services/dialog.service';
import { FieldsService } from 'src/app/services/fields.service';
import { UsersService } from 'src/app/services/users.service';
import { NewFieldDialogComponent } from '../dialogs/new-field-dialog/new-field-dialog.component';
import { TableColumn } from '../table/table.models';

@Component({
    selector: 'app-fields-page',
    templateUrl: './fields-page.component.html',
    styleUrls: ['./fields-page.component.scss']
})
export class FieldsPageComponent extends UnsubscribeOnDestroy implements OnInit {

    readonly columns: TableColumn[] = [{
        name: 'Név',
        dataField: 'name',
    },
    ];
    fields: ProfessionalFieldViewModel[];
    user: UserViewModel | undefined;
    formDisabled = true;

    constructor(
        private readonly fieldsService: FieldsService,
        private readonly usersService: UsersService,
        private readonly dialogService: DialogService,
        private toast: ToastrService,
    ) {
        super();
    }

    ngOnInit(): void {
        this.getData();
    }

    private getData(): void {
        this.subscribe(this.fieldsService.getFields().pipe(
            map((response) => response.professionalFields),
            tap((fields) => this.fields = fields)
        ));
        this.subscribe(this.usersService.getCurrentUser().pipe(
            tap((user) => {
                this.user = user;
                this.formDisabled = user.role !== Role.Admin;
            })
        ));
    }

    addField(): void {
        const dialogRef = this.dialogService.openDialog(NewFieldDialogComponent);
        this.subscribe(dialogRef.afterClosed().pipe(
            filter((result) => !!result?.isSuccessful),
            tap(() => {
                this.getData();
                this.toast.success('Szakterület sikeresen hozzáadva.');
            }),
        ));
    }
}
