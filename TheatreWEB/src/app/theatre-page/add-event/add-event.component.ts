import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-event',
  templateUrl: './add-event.component.html',
  styleUrls: ['./add-event.component.scss']
})
export class AddEventComponent implements OnInit {

  minDate = new Date().toISOString().split('T')[0];
  date = '';
  time = '';

  constructor() { }

  ngOnInit(): void {
  }

  onSubmit() {
    console.log('Selected date and time:', this.date, this.time);
  }

  onTimeChange(event: any) {
    const timeValue = event.target.value;
    const hour = parseInt(timeValue.split(':')[0], 10);

    if (hour % 2 !== 0) {
      const evenHour = hour + 1;
      const evenTimeString = (evenHour < 10 ? '0' : '') + evenHour + timeValue.substring(2);
      this.time = evenTimeString;
    }
  }
}
