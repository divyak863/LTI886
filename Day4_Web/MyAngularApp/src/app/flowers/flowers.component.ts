import { Component, OnInit } from '@angular/core';
import { Flower } from '../models/flower';
import { FlowerService } from '../services/flower.service';

@Component({
  selector: 'app-flowers',
  templateUrl: './flowers.component.html',
  styleUrls: ['./flowers.component.css']
})
export class FlowersComponent implements OnInit {

 flowers:Flower[];
 qty:number[];
  constructor(private  flowerService:FlowerService) {
    this.flowers = this.flowerService.getFlowers();
    this.qty=[];
    this.setQuantity();
   }
   setQuantity(){
      this.flowers.forEach(element => {
        this.qty.push(0);
      });
   }
   addToCart(id:any){
    if(this.qty[id-1]>0){
      let flower = new Flower();
      let myFlower = this.flowerService.getFlower(id);
      flower.id = id;
      flower.quantity = this.qty[id-1];
      flower.pic = myFlower.pic;
      flower.name = myFlower.name;
      flower.price = myFlower.price;
      this.flowerService.buyFlower(flower);
      myFlower.quantity -= this.qty[id-1];
      this.qty[id-1] =0;
     }
   }
   addNumber(id:any){
    this.qty[id-1]++;
   }
   reduceNumber(id:any){
    this.qty[id-1]--;
   }
  ngOnInit(): void {
  }

}
