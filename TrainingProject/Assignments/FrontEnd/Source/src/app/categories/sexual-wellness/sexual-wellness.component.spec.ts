import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SexualWellnessComponent } from './sexual-wellness.component';

describe('SexualWellnessComponent', () => {
  let component: SexualWellnessComponent;
  let fixture: ComponentFixture<SexualWellnessComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SexualWellnessComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SexualWellnessComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
