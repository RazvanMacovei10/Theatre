import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TheatrePageRoutingModule } from './theatre-page-routing.module';
import { HomeComponent } from './home/home.component';
import { ScheduleComponent } from './schedule/schedule.component';
import { AddEventComponent } from './add-event/add-event.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    HomeComponent,
    ScheduleComponent,
    AddEventComponent
  ],
  imports: [
    CommonModule,
    TheatrePageRoutingModule,
    FormsModule
  ]
})
export class TheatrePageModule { }
