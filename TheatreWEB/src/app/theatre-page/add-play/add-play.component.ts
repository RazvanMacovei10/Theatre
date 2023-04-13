import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Observable, map } from 'rxjs';
import { Play } from 'src/app/_models/play';
import { AccountService } from 'src/app/_services/account.service';
import { TheatreService } from 'src/app/_services/theatre.service';

@Component({
  selector: 'app-add-play',
  templateUrl: './add-play.component.html',
  styleUrls: ['./add-play.component.scss']
})
export class AddPlayComponent implements OnInit {

  isLoggedIn$: Observable<boolean> = new Observable<boolean>();
  registerForm !: FormGroup;
  constructor(private theatreService: TheatreService, private router: Router, private fb:FormBuilder) { }
  model: Play = {
    id:0,
    name:'',
    description:'',
    image:'',
    actors:'',
    type:'',
  };

  ngOnInit(): void {
    this.registerForm = this.fb.group({
      name: ['', Validators.required],
      description: ['', Validators.required],
      actors: ['', Validators.required],
      type: ['', Validators.required],
      image: [null]
    });
  }

  addPlay() {
    this.model.name=this.registerForm.controls['name'].getRawValue();
    this.model.description=this.registerForm.controls['description'].getRawValue();
    this.model.actors=this.registerForm.controls['actors'].getRawValue();
    this.model.type=this.registerForm.controls['type'].getRawValue();
    this.theatreService.addPlay(this.model).subscribe({
      next: () => {
        this.cancel();
      },
      error: (error) => console.log(error),
    });
  }
  cancel() {
    this.router.navigateByUrl("");
  }
  onFileSelected(event: any) {
    const file: File = event.target.files[0];
    this.fileToByteArray(file).subscribe((byteArray) => {
      this.model.image =window.btoa(String.fromCharCode(...byteArray));
    });
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
