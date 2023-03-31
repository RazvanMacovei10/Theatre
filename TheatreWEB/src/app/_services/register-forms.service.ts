import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { RegisterForm } from '../_models/register-form';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RegisterFormsService {
  baseUrl='https://localhost:7270/api/';
  constructor(private http:HttpClient) { }

  getRegisterForms():Observable<RegisterForm[]>{
    return this.http.get<RegisterForm[]>(this.baseUrl+'RegisterForm');
  }
}
