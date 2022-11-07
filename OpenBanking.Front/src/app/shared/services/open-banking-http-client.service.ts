import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginResponse } from 'src/app/models/login-response';

@Injectable({
  providedIn: 'root',
})
export class OpenBankingHttpClientService<T> {
  private apiUrl: string = 'https://localhost:7163/';
  private defaultHeaders = new HttpHeaders();
  constructor(private httpClient: HttpClient) {
    this.defaultHeaders = new HttpHeaders({
      Accept: 'application/json',
      Authorization: 'Bearer ' + localStorage.getItem('token'),
    })
  }
  get(url?: string): Observable<T> {
    return this.httpClient.get<T>(this.apiUrl + url, {
      headers: this.defaultHeaders,
    });
  }

  login(username?: string, password?: string) {
    const body = {
      username: username,
      password: password,
    };
    return this.httpClient.post<LoginResponse>(
      this.apiUrl + 'api/v1/user/login',
      body
    );
  }
  logout() {
    return this.httpClient.post(this.apiUrl + 'api/v1/user/logout', {
      headers: this.defaultHeaders,
    });
  }
}
