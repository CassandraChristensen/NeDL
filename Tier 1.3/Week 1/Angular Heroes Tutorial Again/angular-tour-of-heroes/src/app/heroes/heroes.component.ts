import { Component, OnInit } from '@angular/core';
import { Hero } from '../hero';
import { HeroService } from '../hero.service';
import { MessageService } from '../message.service';


//@Component is a decorator function and specifies the metadata for this component
//Selector matches the name of the HTML element that identifies this component w/in the parent components HTML template. 
//Template can be either inline, or a filepath. This is the HTML 
//Style is the CSS
@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})


//class will always have export in front of it so it may be imported elsewhere. 
export class HeroesComponent implements OnInit {

  heroes: Hero[] = [];

  //The parameter simultaneously defines a private heroService property and identifies it as a HeroService injection site.
  //When Angular creates a HeroesComponent, the Dependency Injection system sets the heroService parameter to the singleton instance of HeroService.
  constructor(private heroService: HeroService) { }

  //This is a lifecycle hook. This is a goo dplace to put initialization logic. 
  ngOnInit(): void {
    this.getHeroes();
  }


  // Asynchronous signature for an HttpClient.get method. 
  getHeroes(): void {
    this.heroService.getHeroes()
        .subscribe(heroes => this.heroes = heroes);
  }
  
  

}
