import { Component, OnInit } from '@angular/core';
import { map, Observable } from 'rxjs';
import { AccountService } from 'src/app/_services/account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  isLoggedIn$:Observable<boolean>=new Observable<boolean>()
  model:any={}
  constructor(private accountService:AccountService) { }

  ngOnInit(): void {
    this.isLoggedIn$ = this.accountService.currentUser$.pipe(
      map(user => !!user)
    );
  }

  login(){
    this.accountService.login(this.model).subscribe({
      next:response=>{
        console.log(response);
      },
      error:error=>console.log(error)
    })
  }
  logout(){
    this.accountService.logout();
  }
}
