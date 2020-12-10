import { SrvRecord } from 'dns';

export class Org{
    id:number;
    name:string;
    username:string;
    constructor(id:number=0,name:string="",username:string=""){
        this.id=id;
        this.name = name;
        this.username = username;
    }
}