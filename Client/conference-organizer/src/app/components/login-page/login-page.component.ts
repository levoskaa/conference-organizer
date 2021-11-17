import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
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
    formControls: Record<keyof LoginDto, FormControl> = {
        username: new FormControl(null, [Validators.required]),
        password: new FormControl(null, [Validators.required])
    };
    form = new FormGroup(this.formControls);

    constructor(private readonly authService: AuthService) {
        super();
    }

    login(): void {
        this.subscribe(this.authService.login(this.form.value).pipe(
            tap((token) => console.log(token))
        ));
    }
}
