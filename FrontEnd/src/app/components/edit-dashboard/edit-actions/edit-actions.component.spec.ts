import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditActionsComponent } from './edit-actions.component';

describe('EditActionsComponent', () => {
  let component: EditActionsComponent;
  let fixture: ComponentFixture<EditActionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditActionsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditActionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
