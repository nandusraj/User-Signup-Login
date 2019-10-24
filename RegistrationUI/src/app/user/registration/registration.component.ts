import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/shared/user.service';
import { ToastrService } from 'ngx-toastr';
@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styles: []
})
export class RegistrationComponent implements OnInit {

  constructor(public service:UserService,private toastr: ToastrService) { }

  ngOnInit() {
    this.service.formModel.reset();
  }
  onSubmit(){    
    
    this.service.register().subscribe(      
      (res:any)=>{if(res.succeeded){
        this.service.formModel.reset();
      }}
    ,err=>{console.log(err)}    )
    // this.service.formModel.reset();
    this.service.formModel.reset();
    this.toastr.success("You have successfully registered your account.","Registered");
  }

}
