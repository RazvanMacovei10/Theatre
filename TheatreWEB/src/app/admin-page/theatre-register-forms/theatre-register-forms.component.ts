import { Component, Input, OnInit } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { Observable } from 'rxjs';
import { RegisterForm } from '../../_models/register-form';

@Component({
  selector: 'app-theatre-register-forms',
  templateUrl: './theatre-register-forms.component.html',
  styleUrls: ['./theatre-register-forms.component.scss'],
})
export class TheatreRegisterFormsComponent implements OnInit {
  @Input() registerForm: RegisterForm = {
    username: 'defaultUsername',
    address: {
      id: -1,
      city: 'defaultCity',
      street: 'defaultStreet',
      number: 'defaultNumber',
    },
    email:'',
    password:'',
    totalSeats: 'defaultSeats',
    image: '',
  };
  constructor(private sanitizer: DomSanitizer) {
    fetch('assets/default-theatre.jpg')
      .then((response) => response.blob())
      .then((blob) => {
        const file = new File([blob], 'default-theatre.jpg', {
          type: 'image/jpeg',
        });
        this.fileToByteArray(file).subscribe((byteArray) => {
          this.registerForm.image =window.btoa(String.fromCharCode(...byteArray));
        });
      });
  }

  ngOnInit(): void {}

  public byteArrayToImageUrl(): any {
    const encoder=new TextEncoder();
    const blob = new Blob([window.atob(this.registerForm.image)], { type: 'image/jpeg' });
    const safeUrl = URL.createObjectURL(blob);
    return this.sanitizer.bypassSecurityTrustUrl(safeUrl);
  }

  public fileToByteArray(file: File): Observable<Uint8Array> {
    return new Observable((observer) => {
      const reader = new FileReader();
      reader.onload = () => {
        const array = new Uint8Array(reader.result as ArrayBuffer);
        observer.next(array);
        observer.complete();
      };
      reader.readAsArrayBuffer(file);
    });
  }
}
