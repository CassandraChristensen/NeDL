import { Component, OnInit, Input } from '@angular/core';
import { Hero } from '../hero';

@Component({
  selector: 'app-hero-detail',
  templateUrl: './hero-detail.component.html',
  styleUrls: ['./hero-detail.component.css']
})
export class HeroDetailComponent implements OnInit {

  //This property must be an Input property decorated with the @Input() decorator because the external HeroesComponent will bind to it using property binding 
  @Input() hero?: Hero;

  constructor() { }

  ngOnInit(): void {
  }

}
