import { Component, OnInit } from '@angular/core';
import { UserService } from '../shared/user.service';
import { courses } from '../shared/course.model';

@Component({
  selector: 'app-frontend',
  templateUrl: './frontend.component.html',
  styleUrls: ['./frontend.component.css']
})
export class FrontendComponent implements OnInit {
  c:courses[];
  constructor(public service:UserService) { }

  ngOnInit() {
    this.getCourse();
    
    console.log(this.c);
  }

  getCourse(){
    this.service.getCourses().subscribe((data:any[])=>{
      this.c=data;
    })
  }

}
