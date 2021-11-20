import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Role, SectionViewModel } from '@models/generated';
import { combineLatest } from 'rxjs';
import { map, switchMap, tap } from 'rxjs/operators';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { ConferencesService } from 'src/app/services/conferences.service';
import { UsersService } from 'src/app/services/users.service';
import { TableColumn } from '../table/table.models';

@Component({
    selector: 'app-conference-details',
    templateUrl: './conference-details.component.html',
    styleUrls: ['./conference-details.component.scss']
})
export class ConferenceDetailsComponent extends UnsubscribeOnDestroy implements OnInit {
    formDisabled = true;
    sections: SectionViewModel[] = [];

    formControls = {
        name: new FormControl(null, Validators.required),
        dateRange: new FormGroup({
            start: new FormControl(null, Validators.required),
            end: new FormControl(null, Validators.required),
        }),
    }
    form = new FormGroup(this.formControls);

    readonly sectionColumns: TableColumn[] = [{
        name: "Téma",
        dataField: "field",
    },
    {
        name: "Elnök",
        dataField: "chairman",
    },
    {
        name: "Terem",
        dataField: "room",
    },
    {
        name: "Kezdet",
        dataField: "beginDate",
    },
    {
        name: "Vég",
        dataField: "endDate",
    },];

    constructor(private readonly route: ActivatedRoute,
        private readonly conferencesService: ConferencesService,
        private readonly usersService: UsersService,
        private readonly router: Router) {
        super();
    }

    ngOnInit(): void {
        const conference$ = this.route.params.pipe(
            switchMap((params => this.conferencesService.getConference(params['id']))),
            tap((conference) => {
                this.formControls.name.patchValue(conference.name);
                this.formControls.dateRange.controls.start.patchValue(conference.beginDate);
                this.formControls.dateRange.controls.end.patchValue(conference.endDate);
            })
        );
        this.subscribe(combineLatest([conference$, this.usersService.getCurrentUser()]).pipe(
            tap(([conference, user]) => {
                this.formDisabled = !user.editableConferenceIds.includes(conference.id) && user.role !== Role.Admin;
            })
        ));
        this.subscribe(conference$.pipe(
            switchMap((conference) => this.conferencesService.getConferenceSections(conference.id)),
            map((response) => response.sections),
            tap((sections) => this.sections = sections)
        ));
    }

    onSectionClicked(section: SectionViewModel): void {
        this.router.navigate(['/sections', section.id]);
    }
}
