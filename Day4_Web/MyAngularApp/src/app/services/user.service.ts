import { User } from '../models/user';

export class USerService{
    users:User[];
    constructor(){
        this.users = [
            new User("ramu123","Ramu"),
            new User("somu321","Somu")
        ];
    }
    userLogin(user:User):boolean{
        var result:boolean = false;
        this.users.forEach(element => {
            if(element.username == user.username && element.password == user.password)
                result = true;
        });
        return result;
    }
}