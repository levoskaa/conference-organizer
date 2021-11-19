import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { map, tap } from 'rxjs/operators';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { ConferenceViewModel } from 'src/app/models/generated';
import { ConferencesService } from 'src/app/services/conferences.service';
import { TableColumn } from '../table/table.models';

@Component({
    selector: 'app-conferences-page',
    templateUrl: './conferences-page.component.html',
})
export class ConferencesPageComponent extends UnsubscribeOnDestroy implements OnInit {
    readonly columns: TableColumn[] = [{
        name: 'Név',
        dataField: 'name',
    },
    {
        name: 'Kezdet',
        dataField: 'beginDate',
        dataType: 'date',
        format: 'yyyy.MM.dd.'
    },
    {
        name: 'Vég',
        dataField: 'endDate',
        dataType: 'date',
        format: 'yyyy.MM.dd.'
    }];
    conferences: ConferenceViewModel[];

    constructor(private readonly conferencesService: ConferencesService,
        private readonly router: Router) {
        super();
    }

    ngOnInit(): void {
        this.subscribe(this.conferencesService.getConferences().pipe(
            map((response) => response.conferences),
            tap((conferences) => this.conferences = conferences)
        ));
    }

    onRowClicked(conference: ConferenceViewModel): void {
        this.router.navigate(['/conferences', conference.id]);
    }
}
