import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ParticipantByIdDto } from '../models/dtos/participant-by-id-dto';
import { InfoService } from '../shared/info.service';

@Component({
  selector: 'app-info',
  templateUrl: './info.component.html',
  styleUrls: ['./info.component.css'],
})
export class InfoComponent implements OnInit {
  constructor(
    private activeRoute: ActivatedRoute,
    private infoService: InfoService
  ) {}
  teste: boolean = false
  ngOnInit(): void {
    this.activeRoute.params.subscribe((params) => {
      this.infoService.setParticipantById(params['id']);
    });
  }

  getParticipantByIdDto(): ParticipantByIdDto {
    return this.infoService.getParticipant();
  }
  printData() {
    console.log(this.infoService.getParticipant());
    console.log(this.infoService.getParticipant().status);
  }
}
