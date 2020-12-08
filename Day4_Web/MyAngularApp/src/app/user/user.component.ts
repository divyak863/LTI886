import { Component, OnInit } from '@angular/core';
import { User } from '../models/user';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  user:User;
  constructor() { 
    this.user = new User();
  }
register(un:any){
  console.log(un);
}
  ngOnInit(): void {
  }

}
