import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { RegistrationFormValidComponent } from './registration-form-valid/registration-form-valid.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,RegistrationFormValidComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'form-validation-assignment';
}
