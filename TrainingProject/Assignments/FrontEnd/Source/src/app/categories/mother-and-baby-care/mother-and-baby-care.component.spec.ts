import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MotherAndBabyCareComponent } from './mother-and-baby-care.component';

describe('MotherAndBabyCareComponent', () => {
  let component: MotherAndBabyCareComponent;
  let fixture: ComponentFixture<MotherAndBabyCareComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MotherAndBabyCareComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MotherAndBabyCareComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
