import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { LoginPageComponent } from './components/login-page/login-page.component';
import { ProfilePageComponent } from './components/profile-page/profile-page.component';
import { UserAuthGuard } from './guards/user-auth.guard';

const routes: Routes = [
    { path: 'login', component: LoginPageComponent },
    { path: 'profile', component: ProfilePageComponent, canActivate: [UserAuthGuard] },
    { path: '', pathMatch: 'full', component: HomeComponent }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
