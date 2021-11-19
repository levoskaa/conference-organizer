import { ChangeDetectorRef, Component, ElementRef, OnInit } from '@angular/core';
import { MatDrawerContent, MatSidenav } from '@angular/material/sidenav';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/core/auth.service';

@Component({
    selector: 'app-sidenav',
    templateUrl: './sidenav.component.html',
    styleUrls: ['./sidenav.component.scss']
})
export class SidenavComponent implements OnInit {

    isAdminLoggedIn: boolean = false;

    constructor(private authService: AuthService, private router: Router) {
        this.authService.adminLoggedIn.subscribe(res => this.isAdminLoggedInChanged(res));
    }

    isAdminLoggedInChanged(res: boolean): void {
        this.isAdminLoggedIn = res;
    }

    ngOnInit(): void {
    }

    onConferencesClick() {
        this.router.navigate(['/conferences']);
    }

    onUsersClick() {
        this.router.navigate(['/users']);
    }

}
