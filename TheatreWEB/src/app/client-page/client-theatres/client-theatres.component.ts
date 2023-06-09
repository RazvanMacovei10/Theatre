import { Component, OnInit } from '@angular/core';
import { DomSanitizer, SafeUrl } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { Observable, map } from 'rxjs';
import { Event } from 'src/app/_models/event';
import { Play } from 'src/app/_models/play';
import { Theatre } from 'src/app/_models/theatre';
import { AccountService } from 'src/app/_services/account.service';
import { ClientService } from 'src/app/_services/client.service';

@Component({
  selector: 'app-client-theatres',
  templateUrl: './client-theatres.component.html',
  styleUrls: ['./client-theatres.component.scss'],
})
export class ClientTheatresComponent implements OnInit {
  isLoggedIn$: Observable<boolean> = new Observable<boolean>();
  theatreClicked: boolean = false;
  currentEvents:Event[]=[]
  theatres: Theatre[] = [];
  constructor(
    private accountService: AccountService,
    private router: Router,
    private clientService: ClientService,
    private sanitizer: DomSanitizer
  ) {}

  ngOnInit(): void {
    this.isLoggedIn$ = this.accountService.currentUser$.pipe(
      map((user) => !!user)
    );
    this.getEvents();
  }
  logout() {
    this.accountService.logout();
  }

  getEvents() {
    this.clientService.getTheatres().subscribe((data) => {
      this.theatres = data;
    });
  }

  getImageUrl(row: string): SafeUrl {
    const imageDataBytes = new Uint8Array(
      atob(row)
        .split('')
        .map((char) => char.charCodeAt(0))
    );

    const base64ImageData = btoa(String.fromCharCode(...imageDataBytes));

    return this.sanitizer.bypassSecurityTrustUrl(
      'data:image/jpeg;base64,' + base64ImageData
    );
  }

  onCardClick(item: Theatre) {
    this.theatreClicked = true;
    this.currentEvents = item.events;
  }

  onButtonClick() {
    this.theatreClicked = false;
    this.currentEvents=[];
  }
}
