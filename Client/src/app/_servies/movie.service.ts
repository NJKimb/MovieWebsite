import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  http = inject(HttpClient);
  movies: any;

  getMovies() {
    return this.http.get('http://localhost:5002/api/movies');
  } 
}
