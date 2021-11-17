import { Component, ViewChild } from '@angular/core';
import { MatSidenav } from '@angular/material/sidenav';
import { BreakpointObserver } from '@angular/cdk/layout';
import { delay } from 'rxjs/operators';
import { Router } from '@angular/router';
import { AuthService } from './core/auth.service';
import { UnsubscribeOnDestroy } from './core/UnsubscribeOnDestroy';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.scss']
})
export class AppComponent {

    @ViewChild(MatSidenav)
    sidenav!: MatSidenav

    isUserLoggedIn: boolean = false;
    isAdminLoggedIn: boolean = false;

    constructor(private observer: BreakpointObserver, private authService: AuthService, private router: Router) {
        this.authService.adminLoggedIn.subscribe(res => this.changeToAdminNavBar(res));
        this.authService.userLoggedIn.subscribe(res => this.changeToUserNavBar(res));
    }

    changeToAdminNavBar(res: boolean) {
        this.isAdminLoggedIn = res;
    }

    changeToUserNavBar(res: boolean) {
        this.isUserLoggedIn = res;
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
