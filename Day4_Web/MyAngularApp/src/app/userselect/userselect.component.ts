import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-userselect',
  templateUrl: './userselect.component.html',
  styleUrls: ['./userselect.component.css']
})
export class UserselectComponent implements OnInit {

  name:string;
  constructor(private myRoute:Router) {
    this.name = name;
   }

  ngOnInit(): void {
  }
  go(){
    //this.myRoute.navigateByUrl("dummy/"+this.name)
    this.myRoute.navigate(["dummy",this.name]);
  }
}
