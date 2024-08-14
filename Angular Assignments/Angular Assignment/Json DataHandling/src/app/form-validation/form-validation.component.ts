import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { PhonePatternPipe } from '../phone-pattern.pipe';

@Component({
  selector: 'app-form-validation',
  standalone: true,
  imports: [CommonModule,FormsModule,ReactiveFormsModule,PhonePatternPipe],
  templateUrl: './form-validation.component.html',
  styleUrl: './form-validation.component.css'
})
export class FormValidationComponent {
  customValidatorForm: FormGroup;
  constructor(private fb: FormBuilder) {
    this.customValidatorForm = this.fb.group({
      txtno: ['', Validators.compose([Validators.required, Validators.pattern(/^\d{12}$/)])],
    });  
  }
  error_message = {

    number_val: [
      { type: 'required', message: 'Field is required.' },
      { type: 'pattern', message: 'Mobile number must be exactly 12 digits long and only numbers.' }
    ]
    
  };

  txtno1:any;
  onSubmit(){
    if (this.customValidatorForm.valid) {
      this.txtno1 = this.customValidatorForm.value.txtno
      // console.log('Form Submitted', this.customValidatorForm.value);

    }
  }
}
