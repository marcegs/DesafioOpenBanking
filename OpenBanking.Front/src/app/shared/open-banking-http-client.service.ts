import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class OpenBankingHttpClientService<T> {
  private apiUrl: string = 'https://localhost:7163/';
  private defaultHeaders = new HttpHeaders();

  constructor(private httpClient: HttpClient) {
    this.defaultHeaders.append('Accept', 'application/json');
  }

  get(url?: string): Observable<T> {
    return this.httpClient.get<T>(this.apiUrl + url, {
      headers: this.defaultHeaders,
    });
  }
}
