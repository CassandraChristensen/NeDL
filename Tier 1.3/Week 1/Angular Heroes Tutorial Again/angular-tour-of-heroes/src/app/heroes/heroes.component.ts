import { Component, OnInit } from '@angular/core';



//@Component is a decorator function and specifies the metadata for this component
//Selector matches the name of the HTML element that identifies this component w/in the parent components HTML template. 
//Template can be either inline, or a filepath. This is the HTML 
//Style is the CSS
@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})


//class will always have exort in front of it so it may be imported elsewhere. 
export class HeroesComponent implements OnInit {

  hero = 'Windstorm';
  constructor() { }


  //This is a lifecycle hook. This is a goo dplace to put initialization logic. 
  ngOnInit(): void {
  }

}
