import { Component, OnInit } from '@angular/core';
import { Customer } from '../customer/customer';
import { CustomerService } from '../services/customer.service';

@Component({
  selector: 'app-edit-customer',
  templateUrl: './edit-customer.component.html',
  styleUrls: ['./edit-customer.component.css']
})
export class EditCustomerComponent implements OnInit {
  customer:Customer;
  customers:Customer[];
  constructor(private customerService:CustomerService) {
    this.customer = new Customer();
    this.customers = this.customerService.getCustomers();
   }

   updateCustomer(custid:any){
    this.customer.id = custid.value;
    this.customerService.updateCustomer(custid.value,this.customer);
   }
   showCustomer(customerid:any){
    this.customer = this.customerService.getCustomer(customerid.value);
  }
  ngOnInit(): void {
  }

}
