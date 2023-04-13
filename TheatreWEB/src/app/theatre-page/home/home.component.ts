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
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  isLoggedIn$: Observable<boolean> = new Observable<boolean>();
  constructor(
    private accountService: AccountService
  ) {}

  ngOnInit(): void {
    this.isLoggedIn$ = this.accountService.currentUser$.pipe(
      map((user) => !!user)
    );
  }
  logout() {
    this.accountService.logout();
  }
}
