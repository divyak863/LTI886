export class User{
    username:string;
    password:string;
    name:string;
    age:number;
    phone:string;
    constructor(username:string="",
                pasword:string="",
                name:string="",
                age:number=0,
                phone:string="")
                {
                    this.username= username;
                    this.password=pasword;
                    this.name=name;
                    this.age=age;
                    this.phone=phone;
                }
}