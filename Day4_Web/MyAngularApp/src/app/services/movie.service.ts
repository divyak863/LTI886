import { Movie } from '../models/movie';

export class MovieService{
    movies:Movie[];
    constructor(){
        this.movies = [
            new Movie(1,"ABC",121.2),
            new Movie(2,"XYZ",133.2),
            new Movie(3,"AAA",167.1)
        ];
    }
    getMovies():Movie[]{
        return this.movies;
    }
}