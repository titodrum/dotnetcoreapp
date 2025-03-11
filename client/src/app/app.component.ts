import { Component, OnInit, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NavComponent } from './nav/nav.component';
import { AccountService } from './_services/account.service';
import { HomeComponent } from "./home/home.component";

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  imports: [NavComponent, HomeComponent],
})
export class AppComponent implements OnInit {
  private accountService = inject(AccountService)

  ngOnInit(): void {
    this.setCurrentUser()
  }

  setCurrentUser() {
    const userString = localStorage.getItem('user')
    if (userString != null) {
      const user = JSON.parse(userString)
      this.accountService.currentUser.set(user)
    }

  }

 
}
