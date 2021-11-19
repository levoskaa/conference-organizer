import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserViewModel } from '@models/generated';
import { map, tap } from 'rxjs/operators';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { UsersService } from 'src/app/services/users.service';
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
        private readonly router: Router) {
        super();
    }

    ngOnInit(): void {
        this.subscribe(this.usersService.getUsers().pipe(
            map(response => response.users),
            tap(users => this.users = users)
        ));
    }

}
