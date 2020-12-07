export class Customer{
    id:number;
    name:string;
    phone:string;
    pic:string;
    constructor(id:number=0,name:string="",phone:string=""){
        this.id = id;
        this.name = name;
        this.phone = phone;
        this.pic="";
    }
}