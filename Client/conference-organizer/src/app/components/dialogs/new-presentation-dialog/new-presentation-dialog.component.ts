import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { PresentationUpsertDto, ProfessionalFieldViewModel, RoomViewModel, SectionUpsertDto, UserViewModel } from '@models/generated';
import { map, switchMap, tap } from 'rxjs/operators';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { ConferencesService } from 'src/app/services/conferences.service';
import { RoomService } from 'src/app/services/room.service';
import { SectionsService } from 'src/app/services/sections.service';
import { UsersService } from 'src/app/services/users.service';

@Component({
    selector: 'app-new-presentation-dialog',
    templateUrl: './new-presentation-dialog.component.html'
})
export class NewPresentationDialogComponent extends UnsubscribeOnDestroy implements OnInit {

    formControls: Record<keyof PresentationUpsertDto, FormControl> = {
        title: new FormControl(null, Validators.required),
        presenter: new FormControl(null, Validators.required),
    };
    form = new FormGroup(this.formControls);

    constructor(
        @Inject(MAT_DIALOG_DATA) private readonly sectionId: number,
        private readonly dialogRef: MatDialogRef<NewPresentationDialogComponent>,
        private readonly sectionsService: SectionsService,
    ) {
        super();
    }

    ngOnInit(): void {
    }

    submit(): void {
        const dto = this.form.value;
        this.subscribe(this.sectionsService.addPresentation(this.sectionId, dto).pipe(
            tap(() => this.dialogRef.close({ isSuccessful: true }))
        ));
    }

    cancel(): void {
        this.dialogRef.close({ isSuccessful: false });
    }


}
