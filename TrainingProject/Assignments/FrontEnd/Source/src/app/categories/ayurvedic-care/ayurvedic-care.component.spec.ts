import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AyurvedicCareComponent } from './ayurvedic-care.component';

describe('AyurvedicCareComponent', () => {
  let component: AyurvedicCareComponent;
  let fixture: ComponentFixture<AyurvedicCareComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AyurvedicCareComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AyurvedicCareComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
