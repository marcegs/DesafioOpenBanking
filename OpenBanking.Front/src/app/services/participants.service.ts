import { Injectable } from '@angular/core';
import { ParticipantList, Participants } from '../models/participants';
import { OpenBankingHttpClientService } from '../shared/services/open-banking-http-client.service';

@Injectable({
  providedIn: 'root',
})
export class ParticipantsService {
  constructor(private httpClient: OpenBankingHttpClientService<Participants>) {}

  private Participant: Participants = new Participants();
  private currentSelected: ParticipantList = new ParticipantList();
  public getParticipants(): Participants {
    return this.Participant;
  }

  public setParticipants() {
    this.httpClient.get('api/v1/participant').subscribe((data) => {
      this.Participant = data;
    });
  }

  getCurrent() {
    return this.currentSelected;
  }
  updateCurrent(current: ParticipantList) {
    this.currentSelected.active = false;
    this.currentSelected = current;
    this.currentSelected.active = true;
  }
  setCurrentById(id: string)
  {
    let cr = this.Participant.participants?.find(a=>a.id == id)
    console.log(cr)
    if (cr != null) this.updateCurrent(cr)
  }
}
