import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoginserviceService {
checkmobilenumber(mnumber:string)
{
  if(mnumber == '6355367556')
  {
    localStorage.setItem('userMobileNumber','userMobileNumber');
    return true;
  }
  else{
    return false;
  }
}
  constructor() { }
}
