import { Component, OnInit, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RouterOutlet } from '@angular/router';
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  imports: [RouterOutlet, NgFor]
})
export class AppComponent implements OnInit {
  title = 'Demo App!';
  users: any;
  http = inject(HttpClient);


  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/users')
    .subscribe({
      next: response => this.users = response,
      error: error => console.log(error),
      complete: ()=> console.log('Request has completed')
    })
  }
}
