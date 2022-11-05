import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-info',
  templateUrl: './info.component.html',
  styleUrls: ['./info.component.css'],
})
export class InfoComponent implements OnInit {
  constructor(private activeRoute: ActivatedRoute) {}
  id: String | undefined;
  ngOnInit(): void {
    this.activeRoute.params.subscribe((params) => {
      this.id = params['id'];
      this.getInfo();
    });
  }

  getInfo(): void
  {

  }
}
