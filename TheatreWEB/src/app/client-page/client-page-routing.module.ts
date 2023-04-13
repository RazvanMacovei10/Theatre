import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ClientEventsComponent } from './home/client-events/client-events.component';
import { ClientTheatresComponent } from './home/client-theatres/client-theatres.component';

const routes: Routes = [{path:"events",component:ClientEventsComponent},
{path:"theatres",component:ClientTheatresComponent},
{path:"",component:HomeComponent},];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ClientPageRoutingModule { }
