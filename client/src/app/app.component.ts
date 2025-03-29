import { Component, OnInit, inject } from '@angular/core';
import { NavComponent } from './nav/nav.component';
import { AccountService } from './_services/account.service';
import { RouterOutlet } from '@angular/router';
import { LocalStorageService } from './_services/local-storage.service';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  imports: [RouterOutlet, NavComponent],
})
export class AppComponent implements OnInit {
  private accountService = inject(AccountService)
  private localStorage = inject(LocalStorageService)

  ngOnInit(): void {
    this.setCurrentUser()
  }

  setCurrentUser() {
    const userString = this.localStorage.getItem('user')
    if (userString != null) {
      const user = JSON.parse(userString)
      this.accountService.currentUser.set(user)
    }

  }

 
}
