import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmpIdDisplayComponent } from './emp-id-display.component';

describe('EmpIdDisplayComponent', () => {
  let component: EmpIdDisplayComponent;
  let fixture: ComponentFixture<EmpIdDisplayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EmpIdDisplayComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EmpIdDisplayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
