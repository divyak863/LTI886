import { Component, OnInit } from '@angular/core';
import { Customer } from '../customer/customer';
import { CustomerService } from '../services/customer.service';

@Component({
  selector: 'app-addcustomer',
  templateUrl: './addcustomer.component.html',
  styleUrls: ['./addcustomer.component.css']
})
export class AddcustomerComponent implements OnInit {

  customer:Customer;
  //customerService:CustomerService;
  constructor(private customerService:CustomerService) {
    this.customer = new Customer();
    //this.customerService = new CustomerService();
   }

   insertCustomer(){
    this.customerService.addCustomer(this.customer);
    this.customer = new Customer();
   }
  ngOnInit(): void {
   
  }


}
