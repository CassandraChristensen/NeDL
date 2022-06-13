import { Component } from "@angular/core";
import { CoursesService } from "./courses.service";

@Component({
    selector: 'courses', //<courses>,
    template: 
    //Codes of Blocks: 
    //1. data binding - one way binding, interpolation moves data in one direction from my component to HTML elements.
    //2. Pipes (Can go to angular.io and type in types of pipes, it'll give you different formats, like shortDate, longDate etc)
    //3. Custom Pipes. Summary is a custom pipe that comes from summary.pipe.ts
    //4. Data wrapping, event binding and class binding (isActive)
    //5. Two way binding. Allows borr to enter an email into the input, then, that will update the email variable in our component and write the new email to the console log.
    //6. Data binding, and using a constructor that uses Depedency Injection to use a service that gets each of the courses, then use a for loop to print them each out.
    
    `
        <h2>{{ getTitle() }}<h2>

        {{ course.title | uppercase }} <br/>  
        {{ course.students | number }} <br/>
        {{ course.rating | number: '1.1-1'}} <br/>
        {{ course.rating | number: '1.2-2' }}<br/>
        {{ course.price | currency: 'CAD': true: '3.2-2' }} <br/>
        {{ course.releaseDate | date:'shortDate'}}

        {{ text | summary: 10 }}

        <div (click)="onDivClicked()">
            <button class="btn btn-primary" [class.active]="isActive" (click)="onSave($event)">Save</button>
        </div>

        

        
        <input [(ngModel)]="email" (keyup.enter)="onKeyUp()" />
        {{ email | titlecase }}<br/>

        
        <ul>
            <li *ngFor="let course of courses">
            {{ course }}</li>
        <ul>    `
})

export class CoursesComponent {
    
    //1. 
    title = "List of courses";
    
    getTitle(){
        return this.title;
    }

    //2.
    course = { 
        title: "The complete angular course",
        rating: 4.9745,
        students: 30123,
        price: 190.95,
        releaseDate: new Date (2016,3,1)
    }

    //3.
    text ='Lorem Ipsum is simply dummy text of the printing and typeset'

    //4.
    isActive = false;

    onDivClicked(){
        console.log("Div was clicked");
    }

    onSave($event: any){
        $event.stopPropagation();
        console.log("Button was clicked", $event);
    }
    
    //5.
    email = "me@example.com";

    onKeyUp(){
        console.log(this.email);
    }

    //6.
    courses;

    constructor(service: CoursesService){ //Use dependency injection, create an instance of CoursesService and passes it as a parameter. This allows us to decouple class from the service.
        //let service = new CoursesService(); //this is tightly coupled and not great. 
        this.courses = service.getCourses();
    }
    

    

}