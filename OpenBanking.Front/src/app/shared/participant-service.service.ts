import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ParticipantsDto } from '../models/dtos/participant-dto';
import { OpenBankingHttpClientService } from './open-banking-http-client.service';

@Injectable({
  providedIn: 'root',
})
export class ParticipantService {
  constructor(
    private httpClient: OpenBankingHttpClientService<ParticipantsDto>
  ) {}

  private ParticipantDto: ParticipantsDto = new ParticipantsDto;

  public getParticipants(): ParticipantsDto {
    return this.ParticipantDto
  }

  public setParticipantsDto()
  {
    this.httpClient.get('api/v1/participant').subscribe((data) => {
      this.ParticipantDto = data;
    });
  }
}
