export class Employee{
    id:string;
    name:string;
    age:number;
    constructor(id:string="",name:string="",age:number=0){
        this.id = id;
        this.name = name;
        this.age = age;
    }
}