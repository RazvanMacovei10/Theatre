import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Play } from '../_models/play';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TheatreService {

  baseUrl='https://localhost:7270/api/';
  constructor(private http:HttpClient,private router:Router) { }
  addPlay(model:any){
    console.log(model);
    return this.http.post<Play>(this.baseUrl+'Theathre/play',model);
  }
  getPlays(): Observable<Play[]> {
    return this.http.get<Play[]>(this.baseUrl + 'Play');
  }
}
