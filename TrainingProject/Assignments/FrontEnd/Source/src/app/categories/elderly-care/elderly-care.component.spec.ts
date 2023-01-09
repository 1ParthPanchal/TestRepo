import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ElderlyCareComponent } from './elderly-care.component';

describe('ElderlyCareComponent', () => {
  let component: ElderlyCareComponent;
  let fixture: ComponentFixture<ElderlyCareComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ElderlyCareComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ElderlyCareComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
