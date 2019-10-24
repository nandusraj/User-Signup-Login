import { Component, OnInit } from '@angular/core';
import { courses } from '../shared/course.model';
import { UserService } from '../shared/user.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  
  constructor(public service:UserService) { }

  private c:courses[];
  ngOnInit() {
    this.service.getCourses().subscribe((data:any[])=>{
      this.c=data;
    })
    console.log(this.service.course);
  }



}
