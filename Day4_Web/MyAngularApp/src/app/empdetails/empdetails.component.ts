import { Component, OnInit, ɵINJECTOR_IMPL__POST_R3__ } from '@angular/core';
import { Employee } from '../employee/employee';


@Component({
  selector: 'app-empdetails',
  templateUrl: './empdetails.component.html',
  styleUrls: ['./empdetails.component.css']
})
export class EmpdetailsComponent implements OnInit {

  employee:Employee;
  constructor() { 
    this.employee = new Employee("E001","Ramu",23);
  }

  ngOnInit(): void {
  }

}
