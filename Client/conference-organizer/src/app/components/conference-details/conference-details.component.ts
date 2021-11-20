import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ConferenceUpsertDto, ConferenceViewModel, DropDownItemViewModel, Role, SectionViewModel, UserViewModel } from '@models/generated';
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
    conference: ConferenceViewModel;
    sections: SectionViewModel[] = [];
    users: UserViewModel[];

    formControls = {
        name: new FormControl(null, Validators.required),
        dateRange: new FormGroup({
            start: new FormControl(null, Validators.required),
            end: new FormControl(null, Validators.required),
        }),
        editors: new FormControl(null),
    }
    form = new FormGroup(this.formControls);
    formDisabled = true;


    readonly sectionColumns: TableColumn[] = [
        {
            name: 'Téma',
            dataField: 'field',
        },
        {
            name: 'Elnök',
            dataField: 'chairman',
        },
        {
            name: 'Terem',
            dataField: 'room',
        },
        {
            name: 'Kezdet',
            dataField: 'beginDate',
            dataType: 'date',
            format: 'yyyy.MM.dd. HH:mm'
        },
        {
            name: 'Vég',
            dataField: 'endDate',

            dataType: 'date',
            format: 'yyyy.MM.dd. HH:mm'
        },
    ];

    constructor(private readonly route: ActivatedRoute,
        private readonly conferencesService: ConferencesService,
        private readonly usersService: UsersService,
        private readonly router: Router) {
        super();
    }

    ngOnInit(): void {
        this.subscribe(this.usersService.getUsers().pipe(
            map((response) => response.users.filter((user) => user.role !== Role.Admin)),
            tap((users) => this.users = users)
        ));
        this.getData();
    }

    private getData(): void {
        const conference$ = this.route.params.pipe(
            switchMap((params => this.conferencesService.getConference(params['id']))),
            tap((conference) => {
                this.conference = conference;
                this.formControls.name.patchValue(conference.name);
                this.formControls.dateRange.controls.start.patchValue(conference.beginDate);
                this.formControls.dateRange.controls.end.patchValue(conference.endDate);
                this.formControls.editors.patchValue(conference.editorIds);
            }),
        );
        this.subscribe(conference$.pipe(
            switchMap((conference) => this.conferencesService.getConferenceSections(conference.id)),
            map((response) => response.sections),
            tap((sections) => this.sections = sections),
        ));
        this.subscribe(combineLatest([conference$, this.usersService.getCurrentUser()]).pipe(
            tap(([conference, user]) => {
                this.formDisabled = !user.editableConferenceIds.includes(conference.id) && user.role !== Role.Admin;
            }),
        ));
    }

    onSectionClicked(section: SectionViewModel): void {
        this.router.navigate(['/sections', section.id]);
    }

    updateConference(): void {
        const dto: ConferenceUpsertDto = {
            name: this.formControls.name.value,
            beginDate: this.formControls.dateRange.controls.start.value,
            endDate: this.formControls.dateRange.controls.end.value,
            editors: this.formControls.editors.value,
        };
        this.subscribe(this.conferencesService.updateConference(this.conference.id, dto).pipe(
            tap(() => this.getData())
        ));
    }

    deleteConference(): void {
        this.subscribe(this.conferencesService.deleteConference(this.conference.id).pipe(
            tap(() => this.router.navigate(['/conferences'])),
        ));
    }

    addSection(): void {
        // TODO
    }
}
