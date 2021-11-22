import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ConferenceViewModel, PresentationViewModel, ProfessionalFieldViewModel, Role, RoomViewModel, SectionUpsertDto, SectionViewModel, UserViewModel } from '@models/generated';
import { filter, map, switchMap, tap } from 'rxjs/operators';
import { combineLatest } from 'rxjs';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { ConferencesService } from 'src/app/services/conferences.service';
import { DialogService } from 'src/app/services/dialog.service';
import { SectionsService } from 'src/app/services/sections.service';
import { UsersService } from 'src/app/services/users.service';
import { TableColumn } from '../table/table.models';
import { NewPresentationDialogComponent } from '../dialogs/new-presentation-dialog/new-presentation-dialog.component';
import { RoomService } from 'src/app/services/room.service';

@Component({
    selector: 'app-section-details',
    templateUrl: './section-details.component.html',
    styleUrls: ['./section-details.component.scss']
})
export class SectionDetailsComponent extends UnsubscribeOnDestroy implements OnInit {
    conference: ConferenceViewModel;
    section: SectionViewModel;
    presentations: PresentationViewModel[] = [];
    user: UserViewModel | undefined;
    users: UserViewModel[];
    rooms: RoomViewModel[] = [];
    userFields: ProfessionalFieldViewModel[] = [];
    Role = Role;

    formControls = {
        roomId: new FormControl(null, Validators.required),
        chairmanId: new FormControl(null, Validators.required),
        fieldId: new FormControl(null, Validators.required),
        dateRange: new FormGroup({
            start: new FormControl(null, Validators.required),
            end: new FormControl(null, Validators.required),
        }),
    }
    form = new FormGroup(this.formControls);
    formDisabled = true;


    readonly sectionColumns: TableColumn[] = [{
        name: "Cím",
        dataField: "title",
    },
    {
        name: "Előadó",
        dataField: "presenter",
    },];

    constructor(private readonly route: ActivatedRoute,
        private readonly conferencesService: ConferencesService,
        private readonly sectionsService: SectionsService,
        private readonly usersService: UsersService,
        private readonly roomService: RoomService,
        private readonly router: Router,
        private readonly dialogService: DialogService,
    ) {
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
            }),
        );
        this.subscribe(combineLatest([conference$, this.usersService.getCurrentUser()]).pipe(
            tap(([conference, user]) => {
                this.user = user;
                this.formDisabled = !user.editableConferenceIds.includes(conference.id) && user.role !== Role.Admin;
            }),
        ));
        const section$ = this.route.params.pipe(
            switchMap((params => this.sectionsService.getSection(params['id']))),
            tap((section) => {
                this.section = section;
                //this.formControls.fieldId.patchValue(section.field);
                this.formControls.dateRange.controls.start.patchValue(section.beginDate);
                this.formControls.dateRange.controls.end.patchValue(section.endDate);
                //this.formControls.chairmanId.patchValue(section.chairman);
                //this.formControls.roomId.patchValue(section.room);
            }),
        );
        this.subscribe(section$.pipe(
            switchMap((section) => this.sectionsService.getSectionPresentations(section.id)),
            map((response) => response.presentations),
            tap((presentations) => this.presentations = presentations),
        ));
        this.subscribe(this.roomService.getRooms().pipe(
            map((response) => response.rooms),
            tap((rooms) => this.rooms = rooms),
        ));
        this.subscribe(this.formControls.chairmanId.valueChanges.pipe(
            switchMap((userId) => this.usersService.getUserFields(userId)),
            map((response) => response.professionalFields),
            tap((userFields) => this.userFields = userFields),
        ));
    }


    updateSection(): void {
        const dto: SectionUpsertDto = {
            roomId: this.formControls.roomId.value,
            beginDate: this.formControls.dateRange.controls.start.value,
            endDate: this.formControls.dateRange.controls.end.value,
            chairmanId: this.formControls.chairmanId.value,
            fieldId: this.formControls.fieldId.value,
        };
        this.subscribe(this.sectionsService.updateSection(this.section.id, dto).pipe(
            tap(() => this.getData())
        ));
    }

    deleteSection(): void {
        this.subscribe(this.sectionsService.deleteSection(this.section.id).pipe(
            tap(() => this.router.navigate(['/conferences'])),
        ));
    }

    addPresentation(): void {
        const dialogRef = this.dialogService.openDialog(NewPresentationDialogComponent, this.section.id);
        this.subscribe(dialogRef.afterClosed().pipe(
            filter((result) => !!result?.isSuccessful),
            tap(() => this.getData()),
        ));
    }
}
