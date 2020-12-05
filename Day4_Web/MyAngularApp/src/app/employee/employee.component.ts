import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  ename:string;
  empid:string;
  constructor() { 
    this.ename = "Somu";
    this.empid="E001";
  }
  textChange(txt1:any){
    console.log(txt1.value);
    this.ename = txt1.value;
  } 
  idChange(txt1:any){
    this.empid= txt1.value;
  }
  
  ngOnInit(): void {
  }

}
