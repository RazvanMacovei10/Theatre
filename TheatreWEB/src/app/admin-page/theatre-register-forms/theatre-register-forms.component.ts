import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { Observable } from 'rxjs';
import { RegisterForm } from '../../_models/register-form';
import { RegisterFormsService } from 'src/app/_services/register-forms.service';

@Component({
  selector: 'app-theatre-register-forms',
  templateUrl: './theatre-register-forms.component.html',
  styleUrls: ['./theatre-register-forms.component.scss'],
})
export class TheatreRegisterFormsComponent implements OnInit {
  @Input() registerForm: RegisterForm = {
    id: -1,
    username: 'defaultUsername',
    address: {
      id: -1,
      city: 'defaultCity',
      street: 'defaultStreet',
      number: 'defaultNumber',
    },
    email: '',
    password: '',
    totalSeats: 'defaultSeats',
    image: '',
  };
  @Output() reloadList: EventEmitter<any> = new EventEmitter();
  constructor(
    private sanitizer: DomSanitizer,
    private registerFormService: RegisterFormsService
  ) {
    fetch('assets/default-theatre.jpg')
      .then((response) => response.blob())
      .then((blob) => {
        const file = new File([blob], 'default-theatre.jpg', {
          type: 'image/jpeg',
        });
        this.fileToByteArray(file).subscribe((byteArray) => {
          this.registerForm.image = window.btoa(
            String.fromCharCode(...byteArray)
          );
        });
      });
  }

  ngOnInit(): void {}

  byteArrayToImageUrl(): any {
    const encoder = new TextEncoder();
    const binaryString = window.atob(this.registerForm.image);
    const bytes = new Uint8Array(binaryString.length);
    for (let i = 0; i < binaryString.length; i++) {
      bytes[i] = binaryString.charCodeAt(i);
    }
    const blob = new Blob([bytes], {
      type: 'image/jpeg',
    });
    const safeUrl = URL.createObjectURL(blob);
    return this.sanitizer.bypassSecurityTrustUrl(safeUrl);
  }

  fileToByteArray(file: File): Observable<Uint8Array> {
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
  approveTheatre() {
    this.registerFormService
      .createUser(this.registerForm.id.toString())
      .subscribe(() => this.reloadList.emit(null));
  }
  deleteTheatre() {
    this.registerFormService
      .deleteForm(this.registerForm.id.toString())
      .subscribe(() => this.reloadList.emit());
  }
}
