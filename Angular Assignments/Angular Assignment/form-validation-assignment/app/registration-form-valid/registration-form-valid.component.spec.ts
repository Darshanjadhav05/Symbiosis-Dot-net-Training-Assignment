import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistrationFormValidComponent } from './registration-form-valid.component';

describe('RegistrationFormValidComponent', () => {
  let component: RegistrationFormValidComponent;
  let fixture: ComponentFixture<RegistrationFormValidComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RegistrationFormValidComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RegistrationFormValidComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
