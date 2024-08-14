import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FormValidationComponent } from './form-validation/form-validation.component';
import { EmpIdDisplayComponent } from './emp-id-display/emp-id-display.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,FormValidationComponent,EmpIdDisplayComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Assignments';
}
