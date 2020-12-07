import {Customer} from '../customer/customer';

export class CustomerService{
    customers:Customer[];
    constructor(){
        this.customers = [
            new Customer(101,"Ramu","1234567890"),
            new Customer(102,"Somu","9876543210"),
            new Customer(103,"Bimu","6789054321")
          ];
          this.customers[0].pic = "assets/One.jfif";
          this.customers[1].pic = "assets/Two.jfif";
          this.customers[2].pic = "assets/Three.jfif";
    }

    addCustomer(customer:Customer){
        this.customers.push(customer);
        console.log(this.customers);
    }
    deleteCustomer(id:number){
        for (let index = 0; index < this.customers.length; index++) {
           if(this.customers[index].id==id)
            {
                this.customers.splice(index,1);
                break;
            }            
        }
    }
    getCustomer(id:number):any{
        for (let index = 0; index < this.customers.length; index++) {
            if(this.customers[index].id==id)
             {
                return this.customers[index];
             }            
         }
         return null;
    }
    updateCustomer(id:number,customer:Customer){
        for (let index = 0; index < this.customers.length; index++) {
            if(this.customers[index].id==id)
             {
                this.customers[index] = customer;
             }            
         }
    }
    getCustomers():Customer[]{
        return this.customers;
    }
}