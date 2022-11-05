import { Injectable } from '@angular/core';
import { ParticipantByIdDto } from '../models/dtos/participant-by-id-dto';
import { OpenBankingHttpClientService } from './open-banking-http-client.service';

@Injectable({
  providedIn: 'root',
})
export class InfoService {
  constructor(
    private httpClient: OpenBankingHttpClientService<ParticipantByIdDto>
  ) {}
  private ParticipantByIdDto: ParticipantByIdDto = new ParticipantByIdDto;
  setParticipantById(id: String) {
    this.httpClient.get('api/v1/participant/' + id).subscribe(data => {
      this.ParticipantByIdDto = data;
    });
  }
  getParticipant(): ParticipantByIdDto {
    return this.ParticipantByIdDto;
  }
}
