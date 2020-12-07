import { Component, OnInit } from '@angular/core';
import { Customer } from '../customer/customer';
import { CustomerService } from '../services/customer.service';

@Component({
  selector: 'app-displaycustomer',
  templateUrl: './displaycustomer.component.html',
  styleUrls: ['./displaycustomer.component.css']
})
export class DisplaycustomerComponent implements OnInit {
//customerService:CustomerService;
cust:Customer;
customers:Customer[];
  constructor(private customerService:CustomerService) {
    //this.customerService = new CustomerService();
    this.cust = new Customer();
    this.customers = this.customerService.getCustomers();
   }

   showCustomer(customerid:any){
     this.cust = this.customerService.getCustomer(customerid.value);
   }
  ngOnInit(): void {
  }

}
