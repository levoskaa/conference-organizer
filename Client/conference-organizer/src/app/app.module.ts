import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { SidenavComponent } from './components/sidenav/sidenav.component';
import { HomeComponent } from './components/home/home.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatDividerModule } from '@angular/material/divider';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { LoginPageComponent } from './components/login-page/login-page.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatMenuModule } from '@angular/material/menu';
import { ReactiveFormsModule } from '@angular/forms';
import { ProfilePageComponent } from './components/profile-page/profile-page.component';
import { TableComponent } from './components/table/table.component';
import { MatTableModule } from '@angular/material/table';
import { ConferencesPageComponent } from './components/conferences-page/conferences-page.component';
import { DatePipe } from '@angular/common';
import { ConferenceDetailsComponent } from './components/conference-details/conference-details.component';
import { UsersPageComponent } from './components/users-page/users-page.component';
import { TokenInterceptor } from './core/token.interceptor';
import { AddUserDialogComponent } from './components/dialogs/add-user-dialog/add-user-dialog.component';
import { MatDialogModule } from '@angular/material/dialog';
import { ToastrModule } from 'ngx-toastr';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { SectionDetailsComponent } from './components/section-details/section-details.component';
import { MatNativeDateModule, MAT_DATE_LOCALE } from '@angular/material/core';
import { MatSelectModule } from '@angular/material/select';
import { NewSectionDialogComponent } from './components/dialogs/new-section-dialog/new-section-dialog.component';
import { NewPresentationDialogComponent } from './components/dialogs/new-presentation-dialog/new-presentation-dialog.component';
import { RoomsPageComponent } from './components/rooms-page/rooms-page.component';
import { FieldsPageComponent } from './components/fields-page/fields-page.component';
import { NewRoomDialogComponent } from './components/dialogs/new-room-dialog/new-room-dialog.component';
import { NewFieldDialogComponent } from './components/dialogs/new-field-dialog/new-field-dialog.component';
import { NewConferenceDialogComponent } from './components/dialogs/new-conference-dialog/new-conference-dialog.component';
import { UserDetailsComponent } from './components/user-details/user-details.component';
import { UserFieldsPageComponent } from './components/user-fields-page/user-fields-page.component';
import { AddFieldToUserDialogComponent } from './components/dialogs/add-field-to-user-dialog/add-field-to-user-dialog.component';


@NgModule({
    declarations: [
        AppComponent,
        HeaderComponent,
        SidenavComponent,
        HomeComponent,
        LoginPageComponent,
        ProfilePageComponent,
        TableComponent,
        ConferencesPageComponent,
        ConferenceDetailsComponent,
        UsersPageComponent,
        AddUserDialogComponent,
        SectionDetailsComponent,
        NewSectionDialogComponent,
        NewPresentationDialogComponent,
        RoomsPageComponent,
        FieldsPageComponent,
        NewRoomDialogComponent,
        NewFieldDialogComponent,
        NewConferenceDialogComponent,
        UserDetailsComponent,
        UserFieldsPageComponent,
        AddFieldToUserDialogComponent,
    ],
    imports: [
        BrowserModule,
        HttpClientModule,
        AppRoutingModule,
        BrowserAnimationsModule,
        MatSidenavModule,
        MatToolbarModule,
        MatButtonModule,
        MatIconModule,
        MatDividerModule,
        MatFormFieldModule,
        MatInputModule,
        ReactiveFormsModule,
        MatMenuModule,
        MatTableModule,
        MatDialogModule,
        ToastrModule.forRoot({
            positionClass: 'toast-top-center',
            closeButton: true
        }),
        MatDatepickerModule,
        MatNativeDateModule,
        MatSelectModule,
    ],
    providers: [
        DatePipe,
        { provide: HTTP_INTERCEPTORS, useClass: TokenInterceptor, multi: true },
        { provide: MAT_DATE_LOCALE, useValue: 'hu-HU' },
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }
