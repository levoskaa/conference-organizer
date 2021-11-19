import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ConferenceDetailsComponent } from './components/conference-details/conference-details.component';
import { ConferencesPageComponent } from './components/conferences-page/conferences-page.component';
import { HomeComponent } from './components/home/home.component';
import { LoginPageComponent } from './components/login-page/login-page.component';
import { ProfilePageComponent } from './components/profile-page/profile-page.component';
import { UsersPageComponent } from './components/users-page/users-page.component';
import { AdminAuthGuard } from './guards/admin-auth.guard';
import { UserAuthGuard } from './guards/user-auth.guard';

const routes: Routes = [
    { path: 'login', component: LoginPageComponent },
    { path: 'profile', component: ProfilePageComponent, canActivate: [UserAuthGuard] },
    {
        path: 'conferences', children: [
            {
                path: '',
                pathMatch: 'full',
                component: ConferencesPageComponent
            },
            {
                path: ':id',
                component: ConferenceDetailsComponent
            }
        ]
    },
    { path: 'conferences', component: ConferencesPageComponent },
    { path: 'users', component: UsersPageComponent, canActivate: [AdminAuthGuard] },
    { path: '', pathMatch: 'full', component: HomeComponent }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
