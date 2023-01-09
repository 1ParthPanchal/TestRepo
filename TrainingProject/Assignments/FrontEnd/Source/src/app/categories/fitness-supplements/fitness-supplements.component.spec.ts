import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FitnessSupplementsComponent } from './fitness-supplements.component';

describe('FitnessSupplementsComponent', () => {
  let component: FitnessSupplementsComponent;
  let fixture: ComponentFixture<FitnessSupplementsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FitnessSupplementsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FitnessSupplementsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
