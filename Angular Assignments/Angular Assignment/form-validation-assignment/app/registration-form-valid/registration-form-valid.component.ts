import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-registration-form-valid',
  standalone: true,
  imports: [FormsModule, CommonModule, ReactiveFormsModule],
  templateUrl: './registration-form-valid.component.html',
  styleUrls: ['./registration-form-valid.component.css']  
})
export class RegistrationFormValidComponent {
  customValidatorForm: FormGroup;
  age: number | null = null;
  ageError: string | null = null;
  constructor(private fb: FormBuilder) {
    this.customValidatorForm = this.fb.group({
      txtname: ['', Validators.required],
      txtpass: ['', Validators.compose([Validators.required, Validators.minLength(4), Validators.maxLength(8)])],
      txtnewpass: ['', Validators.compose([Validators.required, Validators.minLength(4), Validators.maxLength(8)])],
      mobile: ['', Validators.compose([Validators.required, Validators.pattern(/^\d{10}$/)])],
      dateOfBirth: ['', Validators.required]
    }, { validator: passwordMatchValidator });  
  }

  onSubmit() {
    if (this.customValidatorForm.valid) {
      console.log('Form Submitted', this.customValidatorForm.value);
    }
  }

  error_message = {
    txtname: [
      { type: 'required', message: 'Username is required.' }
    ],
    txtpass: [
      { type: 'required', message: 'Password is required.' },
      { type: 'minlength', message: 'Password must be at least 4 characters long.' },
      { type: 'maxlength', message: 'Password cannot be more than 8 characters long.' }
    ],
    txtnewpass: [
      { type: 'required', message: 'New Password is required.' },
      { type: 'minlength', message: 'New Password must be at least 4 characters long.' },
      { type: 'maxlength', message: 'New Password cannot be more than 8 characters long.' },
      { type: 'passwordMismatch', message: 'New password must be the same as old password.' }
    ],
    mobile: [
      { type: 'required', message: 'Mobile number is required.' },
      { type: 'pattern', message: 'Mobile number must be exactly 10 digits long and only numbers.' }
    ],
    dateOfBirth: [
      { type: 'required', message: 'Date of Birth is required.' }
    ]
  };

  calculateAge() {
    const dob = this.customValidatorForm.get('dateOfBirth')?.value;
    if (dob) {
      const birthDate = new Date(dob);
      const today = new Date();
      let age = today.getFullYear() - birthDate.getFullYear();
      const monthDiff = today.getMonth() - birthDate.getMonth();

      if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < birthDate.getDate())) {
        age--;
      }

      this.age = age;
      this.ageError = this.isAgeValid() ? null : 'Age must be between 18 and 100 years.';
    } else {
      this.age = null;
      this.ageError = null;
    }
  }

  private isAgeValid(): boolean {
    return this.age !== null && this.age >= 18 && this.age <= 100;
  }
}

export function passwordMatchValidator(form: FormGroup) {
  const oldPassword = form.get('txtpass')?.value;
  const newPassword = form.get('txtnewpass')?.value;

  return oldPassword && newPassword && oldPassword != newPassword
    ? { passwordMismatch: true }
    : null;
}
