import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminPageRoutingModule } from './admin-page-routing.module';
import { TheatreRegisterFormsComponent } from './theatre-register-forms/theatre-register-forms.component';
import { AdminDefaultComponent } from './admin-default/admin-default.component';


@NgModule({
  declarations: [
    TheatreRegisterFormsComponent,
    AdminDefaultComponent
  ],
  imports: [
    CommonModule,
    AdminPageRoutingModule
  ]
})
export class AdminPageModule { }
