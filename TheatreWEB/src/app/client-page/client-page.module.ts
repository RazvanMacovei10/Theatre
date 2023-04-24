import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ClientPageRoutingModule } from './client-page-routing.module';
import { HomeComponent } from './home/home.component';
import { ClientEventsComponent } from './client-events/client-events.component';
import { ClientTheatresComponent } from './client-theatres/client-theatres.component';
import { ClientNavbarComponent } from './client-navbar/client-navbar.component';


@NgModule({
  declarations: [
    HomeComponent,
    ClientEventsComponent,
    ClientTheatresComponent,
    ClientNavbarComponent
  ],
  imports: [
    CommonModule,
    ClientPageRoutingModule
  ]
})
export class ClientPageModule { }
