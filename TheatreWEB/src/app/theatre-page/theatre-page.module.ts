import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TheatrePageRoutingModule } from './theatre-page-routing.module';
import { HomeComponent } from './home/home.component';


@NgModule({
  declarations: [
    HomeComponent
  ],
  imports: [
    CommonModule,
    TheatrePageRoutingModule
  ]
})
export class TheatrePageModule { }
