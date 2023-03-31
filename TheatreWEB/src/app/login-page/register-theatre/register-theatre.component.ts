import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Observable } from 'rxjs';
import { RegisterForm } from 'src/app/_models/register-form';
import { AccountService } from 'src/app/_services/account.service';

@Component({
  selector: 'app-register-theatre',
  templateUrl: './register-theatre.component.html',
  styleUrls: ['./register-theatre.component.scss'],
})
export class RegisterTheatreComponent implements OnInit {
  @Output() cancelRegister = new EventEmitter();
  model: RegisterForm = {
    address: { city: '', street: '', number: '', id: 0 },
    username: '',
    totalSeats: '',
    id: 0,
    password: '',
    email: '',
    image: new Uint8Array(0),
  };

  constructor(private accountService: AccountService) {}

  ngOnInit(): void {}

  register() {
    this.accountService.register(this.model).subscribe({
      next: () => {
        this.cancel();
      },
      error: (error) => console.log(error),
    });
  }
  cancel() {
    this.cancelRegister.emit(false);
  }
  onFileSelected(event: any) {
    const file: File = event.target.files[0];
    this.fileToByteArray(file).subscribe(data=>this.model.image=data);
    console.log(this.model);
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
