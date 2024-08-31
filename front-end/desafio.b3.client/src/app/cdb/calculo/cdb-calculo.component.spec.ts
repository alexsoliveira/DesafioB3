import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CdbCalculoComponent } from './cdb-calculo.component';

describe('CdbCalculoComponent', () => {
  let component: CdbCalculoComponent;
  let fixture: ComponentFixture<CdbCalculoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CdbCalculoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CdbCalculoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
