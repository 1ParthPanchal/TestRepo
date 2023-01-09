import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DettolComponent } from './dettol.component';

describe('DettolComponent', () => {
  let component: DettolComponent;
  let fixture: ComponentFixture<DettolComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DettolComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DettolComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
