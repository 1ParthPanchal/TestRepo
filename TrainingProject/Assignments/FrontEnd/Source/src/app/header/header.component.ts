import { Component, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import * as firebase from '../../../node_modules/firebase/compat';
import '../../../node_modules/firebase/compat/firestore'
import '../../../node_modules/firebase/auth';
import '../../../node_modules/firebase/firestore';
import { LoginserviceService } from '../services/loginservice.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})

export class HeaderComponent implements OnInit {
signIn() {
throw new Error('Method not implemented.');
}
 
  
  
  //otp: string | undefined; showOtpComponent = true; 
  @ViewChild("ngOtpInput", { static: false }) ngOtpInput: any; config = { allowNumbersOnly: true, length: 4, isPasswordInput: false, disableAutoFocus: false, placeholder: "*", inputStyles: { width: "50px", height: "50px", }, }; 
  confirmationResult: any;
  recaptchaVerifier!: firebase.default.auth.RecaptchaVerifier;
  constructor(private service: LoginserviceService,private routes:Router ){}
  ngOnInit(): void {
   window.recaptchaVerifier = new firebase.default.auth.RecaptchaVerifier('sign-in-button');
    console.log(window.recaptchaVerifier);
    throw new Error('Method not implemented.');
  }
  // Mobilenumber:number|undefined;
  msg: string | undefined;
  otpSent: boolean = false
  phoneNumber = null
  otp = null
  
 
    check(mnumber:string)
    {
      let output = this.service.checkmobilenumber(mnumber);
      if(output == true)
      {
        this.routes.navigate(['body']);
      }
      else{
        this.msg = "invalid Username and Password";
      }
    }
    myFunction() {
      location.replace('src\app\post\post.component.html')
    }
  
  // OTP Code onOtpChange(otp) { this.otp = otp; // When all 4 digits are filled, trigger OTP validation method if (otp.length == 4) { this.validateOtp(); } } setVal(val) { this.ngOtpInput.setValue(val); } onConfigChange() { this.showOtpComponent = false; this.otp = null; setTimeout(() => { this.showOtpComponent = true; }, 0); } validateOtp() { // write your logic here to validate it, you can integrate sms API here if you want } 
 
 
  sendOTP()
  {

  }


}
function code(code: any) {
  throw new Error('Function not implemented.');
}
declare global {
  interface Window {
    confirmationResult: any;
    recaptchaVerifier:any;
  }
}

