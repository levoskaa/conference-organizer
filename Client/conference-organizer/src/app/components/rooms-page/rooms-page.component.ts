import { Component, OnInit } from '@angular/core';
import { Role, RoomsViewModel, RoomViewModel, UserViewModel } from '@models/generated';
import { ToastrService } from 'ngx-toastr';
import { filter, map, tap } from 'rxjs/operators';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { DialogService } from 'src/app/services/dialog.service';
import { RoomService } from 'src/app/services/room.service';
import { UsersService } from 'src/app/services/users.service';
import { NewRoomDialogComponent } from '../dialogs/new-room-dialog/new-room-dialog.component';
import { TableColumn } from '../table/table.models';

@Component({
    selector: 'app-rooms-page',
    templateUrl: './rooms-page.component.html'
})
export class RoomsPageComponent extends UnsubscribeOnDestroy implements OnInit {
    readonly columns: TableColumn[] = [{
        name: 'Név',
        dataField: 'uniqueName',
    },
    {
        name: 'Kapacitás',
        dataField: 'capacity',
        dataType: 'number',
    },
    ];
    rooms: RoomViewModel[];
    user: UserViewModel | undefined;
    users: UserViewModel[];
    formDisabled = true;


    constructor(
        private readonly roomService: RoomService,
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
        this.subscribe(this.roomService.getRooms().pipe(
            map((response) => response.rooms),
            tap((rooms) => this.rooms = rooms)
        ));
        this.subscribe(this.usersService.getCurrentUser().pipe(
            tap((user) => {
                this.user = user;
                this.formDisabled = user.role !== Role.Admin;
            })
        ));
    }

    addRoom(): void {
        const dialogRef = this.dialogService.openDialog(NewRoomDialogComponent);
        this.subscribe(dialogRef.afterClosed().pipe(
            filter((result) => !!result?.isSuccessful),
            tap(() => {
                this.getData();
                this.toast.success('Szoba sikeresen hozzáadva.');
            }),
        ));
    }
}
