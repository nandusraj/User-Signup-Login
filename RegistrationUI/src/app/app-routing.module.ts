import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserComponent } from './user/user.component';
import { RegistrationComponent } from './user/registration/registration.component';
import { LoginComponent } from './user/login/login.component';
import { HomeComponent } from './home/home.component';


const routes: Routes = [
  { 
    path:'',redirectTo:'/user/login',pathMatch:'full'},
    {path:'user',component:UserComponent,
    children:[{path:'register',component:RegistrationComponent},
    {path:'login',component:LoginComponent},
     ],
},{path:'home',component:HomeComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
