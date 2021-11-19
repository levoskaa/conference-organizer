import { Component, ViewChild } from '@angular/core';
import { MatSidenav } from '@angular/material/sidenav';
import { BreakpointObserver } from '@angular/cdk/layout';
import { delay } from 'rxjs/operators';
import { Router } from '@angular/router';
import { AuthService } from './core/auth.service';
import { UnsubscribeOnDestroy } from './core/UnsubscribeOnDestroy';
import { UserViewModel } from '@models/generated';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.scss']
})
export class AppComponent {

    @ViewChild(MatSidenav)
    sidenav!: MatSidenav

    currentUser: UserViewModel | null;

    constructor(private observer: BreakpointObserver, private authService: AuthService, private router: Router) {
        this.authService.currentUser.subscribe(x => this.currentUser = x);
    }

    logout() {
        this.authService.logout();
    }

    ngAfterViewInit() {
        this.observer
            .observe(['(max-width: 800px)'])
            .pipe(delay(1))
            .subscribe((res) => {
                if (res.matches) {
                    this.sidenav.mode = 'over';
                    this.sidenav.close();
                } else {
                    this.sidenav.mode = 'side';
                    this.sidenav.open();
                }
            });
    }

    title = 'conference-organizer';
}
