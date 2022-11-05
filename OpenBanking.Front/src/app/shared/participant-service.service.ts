import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ParticipantDto } from '../models/dtos/participant-dto';
import { OpenBankingHttpClientService } from './open-banking-http-client.service';

@Injectable({
  providedIn: 'root',
})
export class ParticipantService {
  constructor(private httpClient: OpenBankingHttpClientService<ParticipantDto>) {
  }

  public getParticipants(): Observable<ParticipantDto> {
    return this.httpClient.get('api/v1/participant');
  }
}
