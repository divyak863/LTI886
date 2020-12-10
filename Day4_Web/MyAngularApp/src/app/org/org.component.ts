import { Component, OnInit } from '@angular/core';
import { OrgService } from '../services/org.service';

@Component({
  selector: 'app-org',
  templateUrl: './org.component.html',
  styleUrls: ['./org.component.css']
})
export class OrgComponent implements OnInit {

  arr_org:any;
  constructor(private orgService:OrgService) {
    this.arr_org = [];
   }
  getData(){
    this.orgService.getOrgDataFromApi().subscribe(myData=>{
     // console.log(myData);
      this.arr_org = myData;
    })
  }
  ngOnInit(): void {
  }

}
