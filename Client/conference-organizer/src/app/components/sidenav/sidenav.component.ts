import { ChangeDetectorRef, Component, ElementRef, OnInit } from '@angular/core';
import { MatDrawerContent, MatSidenav } from '@angular/material/sidenav';
import { Router } from '@angular/router';
import { UserViewModel } from '@models/generated';
import { tap } from 'rxjs/operators';
import { AuthService } from 'src/app/core/auth.service';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { Role } from '@models/generated';

@Component({
    selector: 'app-sidenav',
    templateUrl: './sidenav.component.html',
    styleUrls: ['./sidenav.component.scss']
})
export class SidenavComponent extends UnsubscribeOnDestroy implements OnInit {

    currentUser: UserViewModel | null;

    constructor(private authService: AuthService, private router: Router) {
        super();
        this.subscribe(this.authService.currentUser.pipe(
            tap(x => this.currentUser = x)
        ));
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
