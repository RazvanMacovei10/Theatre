import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ClientPageRoutingModule } from './client-page-routing.module';
import { HomeComponent } from './home/home.component';
import { ClientEventsComponent } from './home/client-events/client-events.component';
import { ClientTheatresComponent } from './home/client-theatres/client-theatres.component';


@NgModule({
  declarations: [
    HomeComponent,
    ClientEventsComponent,
    ClientTheatresComponent
  ],
  imports: [
    CommonModule,
    ClientPageRoutingModule
  ]
})
export class ClientPageModule { }
