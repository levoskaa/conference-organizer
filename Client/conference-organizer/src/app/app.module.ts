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
