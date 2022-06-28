import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SuppliersFormsComponent } from './suppliers-forms.component';

describe('SuppliersFormsComponent', () => {
  let component: SuppliersFormsComponent;
  let fixture: ComponentFixture<SuppliersFormsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SuppliersFormsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SuppliersFormsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
