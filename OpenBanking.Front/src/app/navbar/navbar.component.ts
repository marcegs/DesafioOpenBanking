import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  constructor(
    private authService: AuthService,
  ) { }

  ngOnInit(): void {
  }
  logout()
  {
    this.authService.logout()
  }
  isLogedIn(){
    return this.authService.isLogedIn()
  }
  getUserName()
  {
    return this.authService.getUserName()["name"]
  }
}
