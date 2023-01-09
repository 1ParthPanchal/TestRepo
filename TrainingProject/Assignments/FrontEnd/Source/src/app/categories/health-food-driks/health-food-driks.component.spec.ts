import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HealthFoodDriksComponent } from './health-food-driks.component';

describe('HealthFoodDriksComponent', () => {
  let component: HealthFoodDriksComponent;
  let fixture: ComponentFixture<HealthFoodDriksComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HealthFoodDriksComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HealthFoodDriksComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
