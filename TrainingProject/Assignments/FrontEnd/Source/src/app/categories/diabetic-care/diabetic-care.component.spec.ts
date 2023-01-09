import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DiabeticCareComponent } from './diabetic-care.component';

describe('DiabeticCareComponent', () => {
  let component: DiabeticCareComponent;
  let fixture: ComponentFixture<DiabeticCareComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DiabeticCareComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DiabeticCareComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
