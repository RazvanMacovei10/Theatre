import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { BehaviorSubject, map } from 'rxjs';
import { User } from '../_models/user';
import { RegisterForm } from '../_models/register-form';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  baseUrl = 'https://localhost:7270/api/';
  private currentUserSource = new BehaviorSubject<User | null>(null);
  currentUser$=this.currentUserSource.asObservable();

  constructor(private http:HttpClient,private router:Router) { }

  public get userValue(){
    return this.currentUserSource.value;
  }

  login(model:any){
    return this.http.post<User>(this.baseUrl+'account/login',model).pipe(
      map((response:User) => {
        const user = response;
        if(user){
          localStorage.setItem('user',JSON.stringify(user));
          this.currentUserSource.next(user);
        }
      })
    )
  }

  register(model:any){
    return this.http.post<User>(this.baseUrl+'account/register',model).pipe(
      map(user=>{
        if(user){
          localStorage.setItem('user',JSON.stringify(user));
          this.currentUserSource.next(user);
        }
        return user;
      })
    )
  }

  
  registerTheatre(model:any){
    return this.http.post<RegisterForm>(this.baseUrl+'Account/register-theatre',model);
  }

  setCurrentUser(user:User){
    this.currentUserSource.next(user);
  }

  logout(){
    localStorage.removeItem('user');
    this.currentUserSource.next(null);
    this.router.navigate(['/auth']);
  }
}
