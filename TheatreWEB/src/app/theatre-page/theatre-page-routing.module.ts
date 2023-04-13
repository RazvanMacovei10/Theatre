import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ScheduleComponent } from './schedule/schedule.component';
import { combineLatest } from 'rxjs';
import { AddEventComponent } from './add-event/add-event.component';
import { AddPlayComponent } from './add-play/add-play.component';
import { PlaysComponent } from './plays/plays.component';

const routes: Routes = [
  { path: 'schedule', component: ScheduleComponent },
  { path: 'play', component: PlaysComponent },
  { path: 'schedule/add', component: AddEventComponent },
  { path: 'play/add', component: AddPlayComponent },
  { path: '', redirectTo: '/theatre/play', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class TheatrePageRoutingModule {}
