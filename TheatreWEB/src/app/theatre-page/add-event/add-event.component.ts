import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable, map } from 'rxjs';
import { AccountService } from 'src/app/_services/account.service';

@Component({
  selector: 'app-add-event',
  templateUrl: './add-event.component.html',
  styleUrls: ['./add-event.component.scss']
})
export class AddEventComponent implements OnInit {
  currentDate = new Date();
  tomorrow = new Date(this.currentDate.getFullYear(), this.currentDate.getMonth(), this.currentDate.getDate() + 1);
  minDate = this.tomorrow.toLocaleDateString('en-CA', { year: 'numeric', month: '2-digit', day: '2-digit' }).split(',')[0];
  date = '';
  time = '';

  constructor() {
   }

  ngOnInit(): void {

  }


  onSubmit() {
  }

  onTimeChange(event: any) {
    const timeValue = event.target.value;
    const hour = parseInt(timeValue.split(':')[0], 10);
    let evenTimeString = '';
    let evenHour = hour;

    if (hour % 2 !== 0) {
       evenHour = hour + 1;
    }
    evenTimeString = (evenHour < 10 ? '0' : '') + evenHour;
    this.time = evenTimeString + ':00';
  }
}
