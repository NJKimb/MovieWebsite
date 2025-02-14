import { HttpClient } from '@angular/common/http';
import { Component, inject, input } from '@angular/core';
import { SearchService } from '../_servies/search.service';
import { NavComponent } from "../nav/nav.component";
import { MovieListItemComponent } from "../movie-list-item/movie-list-item.component";

@Component({
  selector: 'app-search-results-page',
  standalone: true,
  imports: [NavComponent, MovieListItemComponent],
  templateUrl: './search-results-page.component.html',
  styleUrl: './search-results-page.component.css'
})
export class SearchResultsPageComponent {
  searchService = inject(SearchService);
  http = inject(HttpClient)
  filteredMovies = this.searchService.filteredMovies;
}
