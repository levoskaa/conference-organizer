import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { ProfessionalFieldUpsertDto } from '@models/generated';
import { tap } from 'rxjs/operators';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { FieldsService } from 'src/app/services/fields.service';


@Component({
    selector: 'app-new-field-dialog',
    templateUrl: './new-field-dialog.component.html',
    styleUrls: ['./new-field-dialog.component.scss']
})
export class NewFieldDialogComponent extends UnsubscribeOnDestroy implements OnInit {

    formControls: Record<keyof ProfessionalFieldUpsertDto, FormControl> = {
        name: new FormControl(null, Validators.required),
    };
    form = new FormGroup(this.formControls);

    constructor(
        private dialogRef: MatDialogRef<NewFieldDialogComponent>,
        private readonly fieldsService: FieldsService,
    ) {
        super();
    }

    ngOnInit(): void {
    }

    submit(): void {
        const dto = this.form.value;
        this.subscribe(this.fieldsService.addField(dto).pipe(
            tap(() => this.dialogRef.close({ isSuccessful: true }))
        ));
    }

    cancel(): void {
        this.dialogRef.close({ isSuccessful: false });
    }

}
