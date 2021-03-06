import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Role } from '@models/generated';
import { Observable } from 'rxjs';
import { AuthService } from '../core/auth.service';

@Injectable({
    providedIn: 'root'
})
export class AdminAuthGuard implements CanActivate {

    constructor(private readonly router: Router,
        private readonly authService: AuthService) { }


    canActivate(
        route: ActivatedRouteSnapshot,
        state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
        const currentUser = this.authService.currentUserValue;
        if (currentUser?.role === Role.Admin) {
            return true;
        }
        this.router.navigate(['login']);
        return false;
    }

}
