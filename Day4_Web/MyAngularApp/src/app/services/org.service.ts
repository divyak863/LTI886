import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable()
export class OrgService{

    constructor(private http:HttpClient){

    }
     getOrgDataFromApi(){
         return this.http.get("https://jsonplaceholder.typicode.com/users");
     }

}