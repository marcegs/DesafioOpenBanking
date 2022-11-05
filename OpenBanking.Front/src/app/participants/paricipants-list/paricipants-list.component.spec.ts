import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ParicipantsListComponent } from './paricipants-list.component';

describe('ParicipantsListComponent', () => {
  let component: ParicipantsListComponent;
  let fixture: ComponentFixture<ParicipantsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ParicipantsListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ParicipantsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
