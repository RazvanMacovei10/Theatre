import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Play } from '../_models/play';
import { Observable } from 'rxjs';
import { EventSent } from '../_models/event-sent';
import { AccountService } from './account.service';
import { Event } from '../_models/event';

@Injectable({
  providedIn: 'root',
})
export class TheatreService {
  baseUrl = 'https://localhost:7270/api/';
  constructor(private http: HttpClient, private router: Router, private accountService:AccountService) {}
  addPlay(model: any) {
    console.log(model);
    return this.http.post<Play>(this.baseUrl + 'Play', model);
  }
  getPlays(): Observable<Play[]> {
    return this.http.get<Play[]>(this.baseUrl + 'Play');
  }
  deletePlay(id:number): Observable<Play[]> {
    return this.http.delete<Play[]>(this.baseUrl + 'Play/'+id);
  }

  addEvent(model: EventSent) {
    if(this.accountService.userValue!=null){
      model.theatreName=this.accountService.userValue.username;
    }
    console.log(model);
    return this.http.post<EventSent>(this.baseUrl + 'Event', model);
  }

  getEvents(): Observable<Event[]>{
    return this.http.get<Event[]>(this.baseUrl + 'Event');
  }
}
