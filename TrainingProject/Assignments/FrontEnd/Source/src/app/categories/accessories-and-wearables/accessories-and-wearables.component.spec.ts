import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AccessoriesAndWearablesComponent } from './accessories-and-wearables.component';

describe('AccessoriesAndWearablesComponent', () => {
  let component: AccessoriesAndWearablesComponent;
  let fixture: ComponentFixture<AccessoriesAndWearablesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AccessoriesAndWearablesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AccessoriesAndWearablesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
