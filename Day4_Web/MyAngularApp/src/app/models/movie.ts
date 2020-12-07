export class Movie{
    id:number;
    name:string;
    duration:number;
    constructor(id:number=0,name:string="",duration:number=0){
        this.id=id;
        this.name = name;
        this.duration = duration;
    }
}