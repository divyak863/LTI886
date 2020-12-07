import { Component, Input, OnInit } from '@angular/core';
import { Movie } from '../models/movie';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css']
})
export class MovieComponent implements OnInit {

  @Input('myMovie')movie:Movie;
  constructor() { 
    this.movie = new Movie();
  }

  ngOnInit(): void {
  }

}
