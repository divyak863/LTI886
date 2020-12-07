import { Component, OnInit } from '@angular/core';
import { Customer } from '../customer/customer';
import { CustomerService } from '../services/customer.service';

@Component({
  selector: 'app-deletecustomer',
  templateUrl: './deletecustomer.component.html',
  styleUrls: ['./deletecustomer.component.css']
})
export class DeletecustomerComponent implements OnInit {

  customers:Customer[];
  constructor(private customerService:CustomerService) { 
    
    this.customers = this.customerService.getCustomers();
  }
  deleteCustomer(customerid:any){
    this.customerService.deleteCustomer(customerid.value);
  }
  ngOnInit(): void {
  }

}
