import { Component } from '@angular/core';

@Component({
  selector: 'app-like',
  template:`
    <span (click)="increase()" class="glyphicon glyphicon-thumbs-up"></span>
    <br>
  <span (click)="decrease()" class="glyphicon glyphicon-thumbs-down"></span>
  <br>
    {{count}}
    <br>
  `,
  styles:[]
})
export class LikeComponent  {

count=0;
countM:number=-10;
constructor(){
  //this.count =-1;
}
increase(){
  this.count--;
}
decrease(){
  this.count++;
  console.log(this.count);
}
}
