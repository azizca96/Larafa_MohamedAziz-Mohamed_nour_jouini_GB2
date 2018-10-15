
import * as Raven from 'raven-js';
import { NgModule,ErrorHandler,NgZone, isDevMode } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule, XHRBackend, RequestOptions } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';



import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { NavmenuComponent } from './navmenu/navmenu.component';
import { ProprietaireFormComponent } from './proprietaire-form/proprietaire-form.component';
import { ProprietaireService } from './services/proprietaire.service';
import { AppErrorHandler } from './app.error-handler';
import { ProprietaireListComponent } from './proprietaire-list/proprietaire-list.component';
import { PaginationComponent } from './pagination/pagination.component';
// import { AuthService } from './services/auth.service';
import { CallBackComponent } from './call-back/call-back.component';
// import { AuthGuard } from './services/AuthGuard.service ';
import { AdminComponent } from './admin/admin.component';
// import { AdminAuthGuard } from './services/admin-auth-guard.service';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { JwtModule } from '@auth0/angular-jwt';
// import { AuthInterceptor } from './services/token.interceptor.service';
import { MessageService } from './services/message.service';


Raven.config('https://e421445ba39445ce977978c95df2c20c@sentry.io/1074478').install();

@NgModule({

  declarations: [
    AppComponent,
    HomeComponent,
    NavmenuComponent,
    ProprietaireFormComponent,
    ProprietaireListComponent,
    PaginationComponent,
    CallBackComponent,
    AdminComponent,
  
  ],
  
  imports: [
    BrowserModule,
    HttpModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    NgbModule.forRoot(),
    FormsModule,
    AngularFontAwesomeModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'proprietaire', pathMatch: 'full' },
            { path: 'proprietaire', component: ProprietaireListComponent },
            { path: 'proprietaire/new', component: ProprietaireFormComponent },
            { path: 'proprietaire/:id', component: ProprietaireFormComponent },
            { path: 'admin', component: AdminComponent ,
            // canActivate: [ AdminAuthGuard] 
           },
            { path: '**', component: HomeComponent }
        ])
        
  ],
  
  providers: [
    {provide: ErrorHandler , useClass: AppErrorHandler },
    ProprietaireService,MessageService
    // AuthService,
    // AuthGuard,
    // AdminAuthGuard,
  ],
  
  bootstrap: [AppComponent]
})

export class AppModule { }
