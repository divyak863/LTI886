import { Flower } from '../models/flower';

export class FlowerService{
    flowers:Flower[];
    cart:Flower[];
    total:number;
    constructor(){
        this.flowers = [
            new Flower(1,"Rose",25,5,"assets/One.jfif"),
            new Flower(2,"Lilly",12,15,"assets/Two.jfif"),
            new Flower(3,"Orchid",75,4,"assets/Three.jfif")
        ]
        this.cart = [];
        this.total =0;
    }
    getFlowers():Flower[]{
        return this.flowers;
    }
    getCart():Flower[]{
        return this.cart;
    }
    buyFlower(flower:Flower){

        let flag=0;
        this.total =0;
       for (let index = 0; index < this.cart.length; index++) {
          if(this.cart[index].id==flower.id)
          {
              this.cart[index].quantity += flower.quantity;
              flag = 1;
              break;
          } 
       }
       if(flag==0)
         this.cart.push(flower);
         this.cart.forEach(element => {
            this.total+=(element.quantity*element.price);
        });
    }


    getFlower(id:number):any{
        for (let index = 0; index < this.flowers.length; index++) {
            if(this.flowers[index].id == id){
                return this.flowers[index];
            }
        }
        return null;
    }
}