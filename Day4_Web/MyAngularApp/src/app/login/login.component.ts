
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { User } from '../models/user';
import { USerService } from '../services/user.service';
import { NotAllowedUsername } from './notAllowedUsername.validator';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  user:User;
  myForm:FormGroup;
  resultMessage:string;
  constructor(private userService:USerService,private route:Router,private activeRoute:ActivatedRoute) { 
    this.user = new User();
    var un = this.activeRoute.snapshot.params["un"];
    this.myForm = new FormGroup({
      username:new FormControl(un,[Validators.required,Validators.minLength(6),NotAllowedUsername.notAllowedName]),
      password:new FormControl(null,[Validators.required,Validators.pattern("[A-Z][a-z][a-z][a-z]")])
    });
    this.resultMessage = "";

  }

public get username() : any {
  return this.myForm.get("username");
}
public get password() : any {
  return this.myForm.get("password");
}
  loginCheck(){
    console.log(this.username);
   if(this.myForm.valid)
    {
        var user:User = new User();
        user.username = this.username.value;
        user.password = this.password.value;
        if(this.userService.userLogin(user))
            //this.resultMessage  = "Welcome "+ this.username.value;
            this.route.navigate(["movie"]);
        else
            this.resultMessage = "Invalid username or password";
    } 
    

  }
  ngOnInit(): void {
  }

}
