import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BaidyanathComponent } from './baidyanath.component';

describe('BaidyanathComponent', () => {
  let component: BaidyanathComponent;
  let fixture: ComponentFixture<BaidyanathComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BaidyanathComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BaidyanathComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
