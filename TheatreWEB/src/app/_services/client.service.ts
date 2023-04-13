import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ClientService {

  baseUrl = 'https://localhost:7270/api/';
  constructor(private http:HttpClient,private router:Router) { }
  
  getEvents(): Observable<Event[]> {
    return this.http.get<Event[]>(this.baseUrl + 'Event');
  }
}
