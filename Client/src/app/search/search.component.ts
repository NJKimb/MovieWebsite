import { Component, inject, input, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MovieService } from '../_servies/movie.service';
import { SearchService } from '../_servies/search.service';
import { RouterLink, RouterLinkActive, RouterModule } from '@angular/router';

@Component({
  selector: 'app-search',
  standalone: true,
  imports: [FormsModule, RouterLink, RouterLinkActive],
  templateUrl: './search.component.html',
  styleUrl: './search.component.css'
})
export class SearchComponent implements OnInit {
  movieService = inject(MovieService);
  searchService = inject(SearchService);
  movies: any;
  filteredMovies: any;
  model: any = {}

  ngOnInit() {
    this.movieService.getMovies().subscribe({
      next: response => this.movies = response,
      complete: () => console.log("Request completed")
    });
  }

  filterResults(text: string){
    if (text == null){
      this.searchService.filteredMovies = this.movies;
      return;
    }
    else {
      this.filteredMovies = this.movies.filter((movie: { title: string; }) => 
        movie?.title.toLowerCase().includes(text.toLowerCase()));
      this.searchService.filteredMovies = this.filteredMovies;
    }
  }
}
