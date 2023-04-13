import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TheatrePageRoutingModule } from './theatre-page-routing.module';
import { HomeComponent } from './home/home.component';
import { ScheduleComponent } from './schedule/schedule.component';
import { AddEventComponent } from './add-event/add-event.component';
import { AddPlayComponent } from './add-play/add-play.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    HomeComponent,
    ScheduleComponent,
    AddEventComponent,
    AddPlayComponent
  ],
  imports: [
    CommonModule,
    TheatrePageRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class TheatrePageModule { }
