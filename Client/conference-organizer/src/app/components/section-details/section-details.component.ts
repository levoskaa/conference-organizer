import { Component, OnInit } from '@angular/core';
import { PresentationViewModel } from '@models/generated';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';

@Component({
    selector: 'app-section-details',
    templateUrl: './section-details.component.html',
    styleUrls: ['./section-details.component.scss']
})
export class SectionDetailsComponent extends UnsubscribeOnDestroy implements OnInit {
    formDisabled = true;
    presentations: PresentationViewModel[] = [];

    constructor() {
        super();
    }

    ngOnInit(): void {
    }

}
