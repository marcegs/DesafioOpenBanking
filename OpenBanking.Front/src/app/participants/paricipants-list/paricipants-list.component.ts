import { Component, OnInit } from '@angular/core';
import { ParticipantsDto } from 'src/app/models/dtos/participant-dto';
import { ParticipantService } from 'src/app/shared/participant-service.service';

@Component({
  selector: 'app-paricipants-list',
  templateUrl: './paricipants-list.component.html',
  styleUrls: ['./paricipants-list.component.css'],
})
export class ParicipantsListComponent implements OnInit {

  constructor(private ParticipantService: ParticipantService) {}
  ngOnInit(): void {
    this.ParticipantService.setParticipantsDto()
  }

  getParticipants() : ParticipantsDto
  {
    return this.ParticipantService.getParticipants();
  }
}
