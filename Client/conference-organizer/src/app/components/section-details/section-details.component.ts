import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { PresentationViewModel } from '@models/generated';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { SectionsService } from 'src/app/services/sections.service';
import { UsersService } from 'src/app/services/users.service';
import { TableColumn } from '../table/table.models';

@Component({
    selector: 'app-section-details',
    templateUrl: './section-details.component.html',
    styleUrls: ['./section-details.component.scss']
})
export class SectionDetailsComponent extends UnsubscribeOnDestroy implements OnInit {
    formDisabled = true;
    presentations: PresentationViewModel[] = [];

    formControls = {
        field: new FormControl(null, Validators.required),
        chairman: new FormControl(null, Validators.required),
        room: new FormControl(null, Validators.required),
        dateRange: new FormGroup({
            start: new FormControl(null, Validators.required),
            end: new FormControl(null, Validators.required),
        }),
    }
    form = new FormGroup(this.formControls);

    readonly sectionColumns: TableColumn[] = [{
        name: "Cím",
        dataField: "title",
    },
    {
        name: "Előadó",
        dataField: "presenter",
    },];

    constructor(private readonly route: ActivatedRoute,
        private readonly sectionsService: SectionsService,
        private readonly usersService: UsersService,
        private readonly router: Router) {
        super();
    }

    ngOnInit(): void {
    }

}
