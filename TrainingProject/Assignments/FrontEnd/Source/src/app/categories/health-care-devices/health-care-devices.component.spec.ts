import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HealthCareDevicesComponent } from './health-care-devices.component';

describe('HealthCareDevicesComponent', () => {
  let component: HealthCareDevicesComponent;
  let fixture: ComponentFixture<HealthCareDevicesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HealthCareDevicesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HealthCareDevicesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
