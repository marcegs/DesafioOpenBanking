import { Component, OnInit } from '@angular/core';
import { ParticipantList, Participants } from '../models/participants';
import { ParticipantsService } from '../services/participants.service';

@Component({
  selector: 'app-participants',
  templateUrl: './participants.component.html',
  styleUrls: ['./participants.component.css'],
})
export class ParticipantsComponent implements OnInit {
  constructor(private ParticipantService: ParticipantsService) {}

  ngOnInit(): void {
    this.ParticipantService.setParticipants();
  }
  getParticipants(): Participants {
    return this.ParticipantService.getParticipants();
  }
  updateCurrent(part: ParticipantList){
    this.ParticipantService.updateCurrent(part)
  }
}
