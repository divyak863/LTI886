import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-dummy',
  templateUrl: './dummy.component.html',
  styleUrls: ['./dummy.component.css']
})
export class DummyComponent implements OnInit {

  userid:string;
  constructor(private activeRoute:ActivatedRoute) {
    this.userid ="";
    this.userid =this.activeRoute.snapshot.params["id"];
   }

  ngOnInit(): void {
    
  }

}
