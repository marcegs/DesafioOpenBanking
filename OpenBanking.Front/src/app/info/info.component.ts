import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Info } from '../models/info';
import { ParticipantList } from '../models/participants';
import { InfoService } from '../services/info.service';
import { ParticipantsService } from '../services/participants.service';

@Component({
  selector: 'app-info',
  templateUrl: './info.component.html',
  styleUrls: ['./info.component.css'],
})
export class InfoComponent implements OnInit {
  constructor(
    private infoService: InfoService,
    private participantsService: ParticipantsService,
    private activeRoute: ActivatedRoute
  ) {}
  ngOnInit(): void {
    this.activeRoute.params.subscribe((params) => {
      this.infoService.setInfoById(params['id']);
      if (this.participantsService.getCurrent().id == null) {
        window.location.href = ""
      }
    });
  }
  getInfo(): Info {
    //teste
    return this.infoService.getInfo();
  }
  getCurrentParticipant(): ParticipantList {
    return this.participantsService.getCurrent();
  }
}
