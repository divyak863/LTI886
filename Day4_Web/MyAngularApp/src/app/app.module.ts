import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {FirstComponent} from './first/first.component';
import { SecondComponent } from './second/second.component';
import { EmployeeComponent } from './employee/employee.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EmpdetailsComponent } from './empdetails/empdetails.component';
import { LikeComponent } from './like/like.component';
import { CustomerComponent } from './customer/customer.component';
import { CommonModule } from '@angular/common';
import { DisplaycustomerComponent } from './displaycustomer/displaycustomer.component';
import { AddcustomerComponent } from './addcustomer/addcustomer.component';
import { CustomerService } from './services/customer.service';
import { DeletecustomerComponent } from './deletecustomer/deletecustomer.component';
import { EditCustomerComponent } from './edit-customer/edit-customer.component';
import { MovieComponent } from './movie/movie.component';
import { MoviesComponent } from './movies/movies.component';
import { MovieService } from './services/movie.service';
import { FlowersComponent } from './flowers/flowers.component';
import { FlowerComponent } from './flower/flower.component';
import { CartComponent } from './cart/cart.component';
import { FlowerService } from './services/flower.service';
import { UserComponent } from './user/user.component';
import { LoginComponent } from './login/login.component';
import { USerService } from './services/user.service';
import { RouterModule, Routes } from '@angular/router';
import { DummyComponent } from './dummy/dummy.component';
import { UserselectComponent } from './userselect/userselect.component';

var myRoutes:Routes = [
  
  {path:'shop',component:FlowersComponent},
  {path:'register',component:UserComponent},
  {path:'login/:un',component:LoginComponent},
  {path:"",component:FirstComponent},
  {path:'movie',component:MoviesComponent,children:[
    {path:'employee',component:EmployeeComponent}
  ]},
  {path:'employee',component:EmployeeComponent},
  {path:'us',component:UserselectComponent},
  {path:'dummy/:id',component:DummyComponent},
  {path:'**',component:SecondComponent}
  
]

@NgModule({
  declarations: [
    AppComponent,
    FirstComponent,
    SecondComponent,
    EmployeeComponent,
    EmpdetailsComponent,
    LikeComponent,
    CustomerComponent,
    DisplaycustomerComponent,
    AddcustomerComponent,
    DeletecustomerComponent,
    EditCustomerComponent,
    MovieComponent,
    MoviesComponent,
    FlowersComponent,
    FlowerComponent,
    CartComponent,
    UserComponent,
    LoginComponent,
    DummyComponent,
    UserselectComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot(myRoutes)
  ],
  providers: [CustomerService,MovieService,FlowerService,USerService],
  bootstrap: [AppComponent]
})
export class AppModule { }
