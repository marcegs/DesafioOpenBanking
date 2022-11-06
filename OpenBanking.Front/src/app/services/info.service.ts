import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Info, ParticipantByIdDto } from '../models/info';
import { OpenBankingHttpClientService } from '../shared/services/open-banking-http-client.service';

@Injectable({
  providedIn: 'root',
})
export class InfoService {
  private info: Info = new Info();

  constructor(private httpClient: OpenBankingHttpClientService<Info>) {}
  public getInfo(): Info {
    return this.info;
  }

  public setInfoById(id: string) {
    this.httpClient
      .get('api/v1/participant/' + id)
      .subscribe((data) => {
        this.info.participantByIdDto = data.participantByIdDto;
        console.log(this.info.participantByIdDto)
      });
  }
  public teste() {
    // this.info.participantId = "123"
  }
}
