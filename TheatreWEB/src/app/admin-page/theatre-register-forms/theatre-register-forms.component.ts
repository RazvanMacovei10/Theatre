import { Component, Input, OnInit } from '@angular/core';
import { RegisterForm } from '../../_models/register-form';

@Component({
  selector: 'app-theatre-register-forms',
  templateUrl: './theatre-register-forms.component.html',
  styleUrls: ['./theatre-register-forms.component.scss']
})
export class TheatreRegisterFormsComponent implements OnInit {

  @Input() registerForm:RegisterForm={id:-1,username:"defaultUsername",address:{id:-1,city:"defaultCity",street:"defaultStreet",number:"defaultNumber"},totalSeats:"defaultSeats"}
  constructor() { }

  ngOnInit(): void {
  }

}
