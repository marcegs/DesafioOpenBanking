import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { InfoDto } from '../models/dtos/info-dto';
import { OpenBankingHttpClientService } from './open-banking-http-client.service';

@Injectable({
  providedIn: 'root'
})
export class InfoService {
  constructor(private httpClient: OpenBankingHttpClientService<InfoDto>) { }

  public getInfo(id: string): Observable<InfoDto>
  {
    return this.httpClient.get('api/v1/participant/' + id);
  }
}
