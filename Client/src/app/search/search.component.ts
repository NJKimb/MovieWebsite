import { Component, input } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-search',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './search.component.html',
  styleUrl: './search.component.css'
})
export class SearchComponent {
  movies = input.required<any>();
  filteredMovies: any;
  model: any = {}

  filterResults(text: string){
    if (text == null){
      this.filteredMovies = this.movies();
      return;
    }
    else {
      this.filteredMovies = this.movies().filter((movie: { title: string; }) => 
      movie?.title.toLowerCase().includes(text.toLowerCase()));
    }
  }
}
