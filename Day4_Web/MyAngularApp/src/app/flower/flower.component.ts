import { Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
import { Flower } from '../models/flower';

@Component({
  selector: 'app-flower',
  templateUrl: './flower.component.html',
  styleUrls: ['./flower.component.css']
})
export class FlowerComponent implements OnInit,OnChanges {

  @Input()flower:Flower;
  @Output() calculate = new EventEmitter<number>();
  constructor() {
    this.flower = new Flower();
   }
   ngOnChanges(changes: SimpleChanges): void {
    console.log("flower Changed");
    this.calculate.emit(this.flower.price);
    }
  ngOnInit(): void {
  }

}
