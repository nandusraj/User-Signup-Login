import { Injectable } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { HttpClient } from "@angular/common/http";
import { courses } from './course.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {  
  course:courses[];
  readonly uri="http://localhost:5000/api";
  constructor(private fb:FormBuilder,private http:HttpClient) { }
  formModel=this.fb.group({
    UserName:['',Validators.required],
    Email:['',Validators.email],
    FullName:[''],
    Passwords:this.fb.group({
      Password:['',[Validators.required,Validators.minLength(4)]],
      ConfirmPassword:['',Validators.required]
    },{ validator: this.comparePasswords }),
  });
  comparePasswords(fb: FormGroup) {
    let confirmPswrdCtrl = fb.get('ConfirmPassword');
    //passwordMismatch
    //confirmPswrdCtrl.errors={passwordMismatch:true}
    if (confirmPswrdCtrl.errors == null || 'passwordMismatch' in confirmPswrdCtrl.errors) {
      if (fb.get('Password').value != confirmPswrdCtrl.value)
        confirmPswrdCtrl.setErrors({ passwordMismatch: true });
      else
        confirmPswrdCtrl.setErrors(null);
    }
  }


  register(){
    var body={
      UserName:this.formModel.value.UserName,
      FullName:this.formModel.value.FullName,
      Email:this.formModel.value.Email,
      Password:this.formModel.value.Passwords.Password,
    }
   return this.http.post(this.uri+'/ApplicationUser/Register',body);
  }
  login(formData){
    console.log(formData);
    return this.http.post(this.uri+'/ApplicationUser/Login',formData);
  }
  getCourses()
  {
    return this.http.get(this.uri+'/CourseModels');
  }

}
