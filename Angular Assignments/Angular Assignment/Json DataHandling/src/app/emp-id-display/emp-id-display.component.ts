import { Component, numberAttribute } from '@angular/core';
import { EmpServiceService } from '../services/emp-service.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Employees } from '../employees';

@Component({
  selector: 'app-emp-id-display',
  standalone: true,
  imports: [CommonModule,FormsModule],
  templateUrl: './emp-id-display.component.html',
  styleUrl: './emp-id-display.component.css',
})
export class EmpIdDisplayComponent {
  Employee: any = [];
  selectedId: string='';
  selectedEmployee: any;

  constructor(public restApi: EmpServiceService) {}
  ngOnInit() {
    this.loadEmp();
  }
  loadEmp() {
    return this.restApi.getEmp().subscribe((data: {}) => {
      this.Employee = data;
    });
  }
   // selectedEmployeeId: number=0;
   updateemployeeDetails={id:0,name:'',email:'',phone:0}
  
   onSelect() {
    const selectedIdNumber = Number(this.selectedId);
      this.restApi.getEmployee(selectedIdNumber).subscribe((data: Employees) => {
        this.updateemployeeDetails = data;
      });
    
  }
 
}
