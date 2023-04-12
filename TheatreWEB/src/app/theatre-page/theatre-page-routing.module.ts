import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ScheduleComponent } from './schedule/schedule.component';
import { combineLatest } from 'rxjs';
import { AddEventComponent } from './add-event/add-event.component';

const routes: Routes = [
  { path: 'schedule', component: ScheduleComponent },
  { path: 'schedule/add', component: AddEventComponent},
  { path: '', component: HomeComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class TheatrePageRoutingModule {}
