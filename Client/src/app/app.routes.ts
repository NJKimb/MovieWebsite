import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { SearchResultsPageComponent } from './search-results-page/search-results-page.component';

export const routes: Routes = [
    {path: '', component: HomeComponent},
    {path: 'search_results', component: SearchResultsPageComponent}
];
