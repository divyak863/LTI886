import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  className:string;
  check:boolean;
  constructor() {
    this.className = "glyphicon glyphicon-heart";
    this.check = true;
   }
  toggleClass(){
    this.check = !this.check;
    if(this.check==true)
      this.className = "glyphicon glyphicon-heart";
    else
        this.className = "glyphicon glyphicon-heart-empty";
  }
  ngOnInit(): void {
  }

}
