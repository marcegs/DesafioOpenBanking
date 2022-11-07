import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { InfoService } from '../services/info.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private authService: AuthService) { }

  ngOnInit(): void {

  }

  isLogedIn()
  {
    return this.authService.isLogedIn()
  }

}
