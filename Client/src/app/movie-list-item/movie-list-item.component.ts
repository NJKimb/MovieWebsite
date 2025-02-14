import { Component, input } from '@angular/core';

@Component({
  selector: 'app-movie-list-item',
  standalone: true,
  imports: [],
  templateUrl: './movie-list-item.component.html',
  styleUrl: './movie-list-item.component.css'
})
export class MovieListItemComponent {
  movie = input.required<any>();

  getReleaseYear(releaseDate: string) {
    return releaseDate.substring(0, releaseDate.indexOf("-"));
  }
}
