import { Component, inject, OnInit } from '@angular/core';
import { SearchComponent } from '../search/search.component';
import { HttpClient } from '@angular/common/http';
import { NavComponent } from "../nav/nav.component";

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [SearchComponent, NavComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit {
  http = inject(HttpClient);
  movies: any;

  getUsers() {
    this.http.get('http://localhost:5002/api/movies').subscribe({
      next: response => this.movies = response,
      error: error => console.log(error),
      complete: () => console.log("Request Completed")
    });
  } 

  ngOnInit(): void {
    this.getUsers()
  }
}
