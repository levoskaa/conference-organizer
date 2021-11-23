import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ProfessionalFieldViewModel, UserViewModel } from '@models/generated';
import { map, switchMap, tap } from 'rxjs/operators';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { DialogService } from 'src/app/services/dialog.service';
import { UsersService } from 'src/app/services/users.service';
import { TableColumn } from '../table/table.models';

@Component({
    selector: 'app-user-details',
    templateUrl: './user-details.component.html',
    styleUrls: ['./user-details.component.scss']
})
export class UserDetailsComponent extends UnsubscribeOnDestroy implements OnInit {
    user: UserViewModel | undefined;
    userFields: ProfessionalFieldViewModel[];

    formControls = {
        name: new FormControl(null, Validators.required),
        role: new FormControl(null, Validators.required),

    }
    form = new FormGroup(this.formControls);

    readonly userFieldColumns: TableColumn[] = [
        {
            name: 'Téma',
            dataField: 'name',
        },
    ];

    constructor(
        private readonly route: ActivatedRoute,
        private readonly usersService: UsersService,
        private readonly dialogService: DialogService,
    ) {
        super();
    }

    ngOnInit(): void {
        this.getData();
    }

    getData() {
        const user$ = this.route.params.pipe(
            switchMap((params => this.usersService.getUser(params['id']))),
            tap((user) => {
                this.user = user;
                this.formControls.name.patchValue(user.username);
                this.formControls.role.patchValue(user.role);

            }),
        );
        this.subscribe(user$.pipe(
            switchMap((user) => this.usersService.getUserFields(user.id)),
            map((response) => response.professionalFields),
            tap((fields) => this.userFields = fields),
        ));
    }

    updateUser() {
    }

    deleteUser() {

    }

    addUserField() {

    }
}
