import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DisplaycustomerComponent } from './displaycustomer.component';

describe('DisplaycustomerComponent', () => {
  let component: DisplaycustomerComponent;
  let fixture: ComponentFixture<DisplaycustomerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DisplaycustomerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DisplaycustomerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
