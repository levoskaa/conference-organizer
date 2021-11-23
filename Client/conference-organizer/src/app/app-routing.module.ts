import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ConferenceDetailsComponent } from './components/conference-details/conference-details.component';
import { ConferencesPageComponent } from './components/conferences-page/conferences-page.component';
import { FieldsPageComponent } from './components/fields-page/fields-page.component';
import { HomeComponent } from './components/home/home.component';
import { LoginPageComponent } from './components/login-page/login-page.component';
import { ProfilePageComponent } from './components/profile-page/profile-page.component';
import { RoomsPageComponent } from './components/rooms-page/rooms-page.component';
import { SectionDetailsComponent } from './components/section-details/section-details.component';
import { UserDetailsComponent } from './components/user-details/user-details.component';
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
    {
        path: 'sections', children: [
            {
                path: ':id',
                component: SectionDetailsComponent
            }
        ]
    },
    { path: 'conferences', component: ConferencesPageComponent },
    { path: 'rooms', component: RoomsPageComponent },
    { path: 'fields', component: FieldsPageComponent },
    {
        path: 'users', canActivate: [AdminAuthGuard], children: [
            {
                path: '',
                pathMatch: 'full',
                component: UsersPageComponent
            },
            {
                path: ':id',
                component: UserDetailsComponent,
            }
        ]
    },
    { path: '', pathMatch: 'full', component: HomeComponent }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
