import { Injectable } from '@angular/core';
import { OpenBankingHttpClientService } from '../shared/services/open-banking-http-client.service';
import {Router} from '@angular/router';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  constructor(private httpClient: OpenBankingHttpClientService<any>, private router: Router) {}

  login(username?: string, password?: string) {
    this.httpClient.login(username, password).subscribe((data) => {
      if (data.token != null) {
        localStorage.setItem('token', data.token + '');
      }
    });
  }
  logout() {
    localStorage.removeItem('token');
    this.httpClient.logout().subscribe((data) => {});
    this.router.navigateByUrl('');
  }
  isLogedIn() {
    return localStorage.getItem('token') != null;
  }
  getToken() {
    return localStorage.getItem('token');
  }
  getUserName() {
    return JSON.parse(atob((this.getToken() + '').split('.')[1]));
  }
}
