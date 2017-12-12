import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BlacksholesComponent } from './blacksholes.component';

describe('BlacksholesComponent', () => {
  let component: BlacksholesComponent;
  let fixture: ComponentFixture<BlacksholesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BlacksholesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BlacksholesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
