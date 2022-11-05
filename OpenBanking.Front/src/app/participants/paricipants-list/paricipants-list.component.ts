import { Component, OnInit } from '@angular/core';
import { ParticipantDto } from 'src/app/models/dtos/participant-dto';
import { ParticipantService } from 'src/app/shared/participant-service.service';

@Component({
  selector: 'app-paricipants-list',
  templateUrl: './paricipants-list.component.html',
  styleUrls: ['./paricipants-list.component.css'],
})
export class ParicipantsListComponent implements OnInit {
  ParticipantDto: ParticipantDto = new ParticipantDto();

  constructor(private OpenBankingService: ParticipantService) {}
  ngOnInit(): void {
    this.OpenBankingService.getParticipants().subscribe((data) => {
      this.ParticipantDto = data;
    });
  }
}
