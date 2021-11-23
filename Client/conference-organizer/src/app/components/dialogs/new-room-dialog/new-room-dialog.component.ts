import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { RoomUpsertDto } from '@models/generated';
import { tap } from 'rxjs/operators';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { RoomService } from 'src/app/services/room.service';

@Component({
    selector: 'app-new-room-dialog',
    templateUrl: './new-room-dialog.component.html',
    styleUrls: ['./new-room-dialog.component.scss']
})
export class NewRoomDialogComponent extends UnsubscribeOnDestroy implements OnInit {

    formControls: Record<keyof RoomUpsertDto, FormControl> = {
        uniqueName: new FormControl(null, Validators.required),
        capacity: new FormControl(null, Validators.required),
    };
    form = new FormGroup(this.formControls);

    constructor(
        private dialogRef: MatDialogRef<NewRoomDialogComponent>,
        private readonly roomService: RoomService
    ) {
        super();
    }

    ngOnInit(): void {

    }

    submit(): void {
        const dto = this.form.value;
        this.subscribe(this.roomService.addRoom(dto).pipe(
            tap(() => this.dialogRef.close({ isSuccessful: true }))
        ));
    }

    cancel(): void {
        this.dialogRef.close({ isSuccessful: false });
    }

}
