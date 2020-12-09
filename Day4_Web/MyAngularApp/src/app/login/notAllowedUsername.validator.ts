import { AbstractControl } from '@angular/forms';

export class NotAllowedUsername{
    static notAllowedName(control:AbstractControl):any{
        if(control.value == "Admin123")
            return {notAllowedName:'Admin123'}
        else 
           return null;
    }
}