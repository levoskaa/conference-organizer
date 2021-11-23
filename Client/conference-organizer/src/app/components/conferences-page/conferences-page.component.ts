import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { filter, map, tap } from 'rxjs/operators';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { ConferenceViewModel, Role, UserViewModel } from 'src/app/models/generated';
import { ConferencesService } from 'src/app/services/conferences.service';
import { DialogService } from 'src/app/services/dialog.service';
import { UsersService } from 'src/app/services/users.service';
import { NewConferenceDialogComponent } from '../dialogs/new-conference-dialog/new-conference-dialog.component';
import { TableColumn } from '../table/table.models';

@Component({
    selector: 'app-conferences-page',
    templateUrl: './conferences-page.component.html',
})
export class ConferencesPageComponent extends UnsubscribeOnDestroy implements OnInit {
    readonly columns: TableColumn[] = [{
        name: 'Név',
        dataField: 'name',
    },
    {
        name: 'Kezdet',
        dataField: 'beginDate',
        dataType: 'date',
        format: 'yyyy.MM.dd.'
    },
    {
        name: 'Vég',
        dataField: 'endDate',
        dataType: 'date',
        format: 'yyyy.MM.dd.'
    }];
    conferences: ConferenceViewModel[];
    user: UserViewModel | undefined;
    formDisabled = true;

    constructor
        (private readonly conferencesService: ConferencesService,
            private readonly usersService: UsersService,
            private readonly router: Router,
            private toast: ToastrService,
            private readonly dialogService: DialogService,
    ) {
        super();
    }

    ngOnInit(): void {
        this.getData();
    }

    private getData(): void {
        this.subscribe(this.conferencesService.getConferences().pipe(
            map((response) => response.conferences),
            tap((conferences) => this.conferences = conferences)
        ));
        this.subscribe(this.usersService.getCurrentUser().pipe(
            tap((user) => {
                this.user = user;
                this.formDisabled = user.role !== Role.Admin;
            })
        ));
    }

    onRowClicked(conference: ConferenceViewModel): void {
        this.router.navigate(['/conferences', conference.id]);
    }

    addConference(): void {
        const dialogRef = this.dialogService.openDialog(NewConferenceDialogComponent);
        this.subscribe(dialogRef.afterClosed().pipe(
            filter((result) => !!result?.isSuccessful),
            tap(() => {
                this.getData();
                this.toast.success('Konferencia sikeresen hozzáadva.');
            }),
        ));
    }
}
