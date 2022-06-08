//no decorator for services, like there is with components. Essentially a plain typescript class

export class CoursesService {
    getCourses() {
        return ["course1", "course2", "course3"];
    }
}