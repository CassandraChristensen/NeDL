import { CoursesComponent } from './courses.component';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { CourseComponent } from './course/course.component';
import { CoursesService } from './courses.service';
import { SummaryPipe } from './summary.pipe';
import { TitleCasePipe } from './title-case.pipe';
import { FavoriteComponent } from './favorite/favorite.component';


@NgModule({
  declarations: [
    AppComponent,
    CoursesComponent,
    CourseComponent, 
    SummaryPipe, TitleCasePipe, FavoriteComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
    
  ],
  providers: [
    CoursesService  //register the dependency here
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
