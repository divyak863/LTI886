import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from '../models/user';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  user:User;
  constructor(private router:Router) { 
    this.user = new User();
  }
register(un:any){
  console.log(un);
  this.router.navigate(["login",this.user.username]);
}
  ngOnInit(): void {
  }

}
