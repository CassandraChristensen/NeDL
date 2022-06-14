import { Injectable } from '@angular/core';
import { Hero } from './hero';
import { HEROES } from './mock-heroes';
import { Observable, of } from 'rxjs';
import { MessageService } from './message.service';



//Injectable decorator marks this class as one that participates in Dependency Injection. 
//It accepts a metadata object for the service, the same way the component() decorator does for the component classes. 
@Injectable({
  providedIn: 'root'
})
export class HeroService {

  //This is a typical "service-in-service" scenario: You inject the MessageService into the HeroService which is injected into the HeroesComponent.

  constructor(private messageService: MessageService) { }

  getHeroes(): Observable<Hero[]> {
    const heroes = of(HEROES);
    this.messageService.add('HeroService: fetched heroes');
    return heroes;
  }
  
}
