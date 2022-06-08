import { Component } from '@angular/core';
import { AuthorsService } from '../authors.service';

@Component({
  selector: 'authors',
  templateUrl: './authors.component.html',
  styleUrls: ['./authors.component.css']
})
export class AuthorsComponent {
  title = "List of My Favorite Authors";
  authors;
  

  constructor(service: AuthorsService) {
    this.authors = service.getAuthors();
   }

  

}
