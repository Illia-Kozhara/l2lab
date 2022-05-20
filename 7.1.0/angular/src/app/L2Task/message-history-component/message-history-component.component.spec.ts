import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MessageHistoryComponentComponent } from './message-history-component.component';

describe('MessageHistoryComponentComponent', () => {
  let component: MessageHistoryComponentComponent;
  let fixture: ComponentFixture<MessageHistoryComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MessageHistoryComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MessageHistoryComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
