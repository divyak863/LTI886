import { Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { Flower } from '../models/flower';
import { FlowerService } from '../services/flower.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit, OnChanges {

cart:Flower[];
subTotal:number[];
grandTotal:number;
  constructor(public flowerService:FlowerService) {
    this.cart = this.flowerService.getCart();
    this.subTotal = [];
    this.initSubTotal();
    this.grandTotal = this.flowerService.total;
   }
  ngOnChanges(changes: SimpleChanges): void {
  console.log("Changed");
  }
  initSubTotal() {
    this.subTotal = [];
    this.grandTotal = 0;
    this.cart.forEach(element => {
      this.subTotal.push(element.price*element.quantity);
      this.grandTotal += element.price*element.quantity;
    });

  }
  calculateTotal(val:any){
    this.initSubTotal();
    console.log(val);
  }

  ngOnInit(): void {
    console.log("Init of Cart")
  }

}
