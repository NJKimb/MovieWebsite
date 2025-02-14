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
export class HomeComponent {
  http = inject(HttpClient);
  movies: any;

}
