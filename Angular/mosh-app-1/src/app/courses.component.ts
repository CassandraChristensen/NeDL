import { Component } from "@angular/core";
import { CoursesService } from "./courses.service";

@Component({
    selector: 'courses', //<courses>,
    template: `
        <h2>{{ getTitle() }}<h2>
        <ul>
            <li *ngFor="let course of courses">
            {{ course }}</li>
        <ul>    `
})

export class CoursesComponent {
    title = "List of courses";
    courses;

    constructor(service: CoursesService){ //Use dependency injection, create an instance of CoursesService and passes it as a parameter. This allows us to decouple class from the service.
        //let service = new CoursesService(); //this is tightly coupled and not great. 
        this.courses = service.getCourses();
    }
    

    getTitle(){
        return this.title;
    }

}