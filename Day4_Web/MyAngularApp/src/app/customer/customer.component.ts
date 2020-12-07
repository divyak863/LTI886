import { Component, OnInit } from '@angular/core';
import { CustomerService } from '../services/customer.service';
import { Customer } from './customer';


@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {

  //customer:Customer;
  //customerService:CustomerService
  customers:Customer[];
  constructor(private customerService:CustomerService) { 
    //this.customer = new Customer(101,"Ramu","1234567890");
   // this.customerService = new CustomerService();
    this.customers = this.customerService.getCustomers();
  }

  ngOnInit(): void {
  }

}
