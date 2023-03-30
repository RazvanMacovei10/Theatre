import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { map, Observable } from 'rxjs';
import { AccountService } from 'src/app/_services/account.service';

@Component({
  selector: 'app-admin-default',
  templateUrl: './admin-default.component.html',
  styleUrls: ['./admin-default.component.scss']
})
export class AdminDefaultComponent implements OnInit {
  isLoggedIn$:Observable<boolean>=new Observable<boolean>()
  
  constructor(private accountService:AccountService,private router:Router) { }

  ngOnInit(): void {
    this.isLoggedIn$ = this.accountService.currentUser$.pipe(
      map(user => !!user)
    );
  }

  logout(){
    this.accountService.logout();
    this.router.navigate(['/auth']);
  }

}
