import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {FirstComponent} from './first/first.component';
import { SecondComponent } from './second/second.component';
import { EmployeeComponent } from './employee/employee.component';
import { FormsModule } from '@angular/forms';
import { EmpdetailsComponent } from './empdetails/empdetails.component';
import { UserComponent } from './user/user.component';
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

@NgModule({
  declarations: [
    AppComponent,
    FirstComponent,
    SecondComponent,
    EmployeeComponent,
    EmpdetailsComponent,
    UserComponent,
    LikeComponent,
    CustomerComponent,
    DisplaycustomerComponent,
    AddcustomerComponent,
    DeletecustomerComponent,
    EditCustomerComponent,
    MovieComponent,
    MoviesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [CustomerService,MovieService],
  bootstrap: [AppComponent]
})
export class AppModule { }
