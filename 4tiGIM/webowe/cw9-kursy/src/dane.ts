class Course {
   
    constructor(public id:number,public name:string,
        public date:Date = new Date(),
        public place:string="Kraków"){        
    }
    info(){
        return `Tytuł kursu: ${this.name} data: ${this.date.toLocaleDateString()} miejsce: ${this.place}`;
    }
    
}

export const Courses:Array<Course> = [
    new Course(1,"ABC programowania JS",new Date("2023-12-04"),"Kraków"),
    new Course(2,"Python wstęp",new Date("2023-06-23"),"Kraków"),
    new Course(3,"React -omówienie",new Date("2024-08-12"),"Warszawa"),
    new Course(4,"C++ i obiekty",new Date("2023-03-28"),"Warszawa"),
    new Course(5,"C++ i obiekty 2",new Date(),"Warszawa"),
];