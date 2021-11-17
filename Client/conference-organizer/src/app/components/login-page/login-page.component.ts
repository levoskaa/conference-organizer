import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { tap } from 'rxjs/operators';
import { AuthService } from 'src/app/core/auth.service';
import { UnsubscribeOnDestroy } from 'src/app/core/UnsubscribeOnDestroy';
import { LoginDto } from 'src/app/models/generated';

@Component({
    selector: 'app-login-page',
    templateUrl: './login-page.component.html',
    styleUrls: ['./login-page.component.scss']
})
export class LoginPageComponent extends UnsubscribeOnDestroy {

    hidePassword = true;
    isLoggedIn = false;

    formControls: Record<keyof LoginDto, FormControl> = {
        username: new FormControl(null, [Validators.required]),
        password: new FormControl(null, [Validators.required])
    };
    form = new FormGroup(this.formControls);

    constructor(private readonly authService: AuthService,
        private readonly router: Router) {
        super();
    }

    login(): void {
        this.subscribe(this.authService.login(this.form.value).pipe(
            tap((token) => console.log(token)),
            tap(() => this.authService.userLoggedin()),
            tap(() => this.router.navigate(['']))
        ));
    }
}
