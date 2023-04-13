import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { DomSanitizer, SafeUrl } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { Observable, map } from 'rxjs';
import { Play } from 'src/app/_models/play';
import { AccountService } from 'src/app/_services/account.service';
import { TheatreService } from 'src/app/_services/theatre.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  isLoggedIn$: Observable<boolean> = new Observable<boolean>();
  constructor(private accountService: AccountService, private router: Router,private http:HttpClient,private sanitizer:DomSanitizer,private theatreService:TheatreService) { }
  plays:Play[]=[];

  ngOnInit(): void {
    this.isLoggedIn$ = this.accountService.currentUser$.pipe(
      map((user) => !!user)
    );
    this.getPlays();
  }
  logout() {
    this.accountService.logout();
  }

  getPlays(){
    this.theatreService.getPlays().subscribe((data)=>{this.plays=data});
  }
  
  getImageUrl(row: Play): SafeUrl {

    const imageDataBytes = new Uint8Array(atob(row.image).split('').map(char => char.charCodeAt(0)));
    

    const base64ImageData = btoa(String.fromCharCode(...imageDataBytes));
    

    return this.sanitizer.bypassSecurityTrustUrl('data:image/jpeg;base64,' + base64ImageData);
  }

}
