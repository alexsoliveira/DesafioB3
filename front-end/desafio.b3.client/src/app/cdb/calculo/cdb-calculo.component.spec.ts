import { ComponentFixture, TestBed, TestComponentRenderer } from '@angular/core/testing';

import { CdbCalculoComponent } from './cdb-calculo.component';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { CdbRoutingModule } from '../cdb.route';
import { CdbService } from '../services/cdb.service';
import { HttpClientModule } from '@angular/common/http';

describe('Teste funcionalidade do componente CdbCalculoComponent', async () => {
  let component: CdbCalculoComponent;
  let fixture: ComponentFixture<CdbCalculoComponent>;  

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CdbCalculoComponent ],
      imports: [
        CommonModule,        
        CdbRoutingModule,
        FormsModule,
        ReactiveFormsModule,
        HttpClientModule 
      ],
      providers: [
        CdbService
      ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CdbCalculoComponent);
    component = fixture.componentInstance;
        
    fixture.detectChanges();
  });

  it('Teste deve criar component CdbCalculoComponent', () => {
    expect(component).toBeTruthy();
  });

  it('Teste deve desabilitar botão Calcular, quando o campos são inválidos', async () => { 
    component.cdbForm = new FormGroup({
      valorMonetario: new FormControl(0, Validators.required),
      mes: new FormControl(1, Validators.required),      
    });
    
    fixture.detectChanges();

    const button = fixture.nativeElement.querySelector('button');
    expect(button.disabled).toBe(true);
  });

  it('Teste deve habilitar botão Calcular, quando o campos são válidos', async () => {        
    component.cdbForm = new FormGroup({
      valorMonetario: new FormControl(100, Validators.required),
      mes: new FormControl(2, Validators.required),      
    });
    
    fixture.detectChanges();

    const button = fixture.nativeElement.querySelector('button');
    expect(button.disabled).toBe(false);
  });

  it('Teste deve fazer o calcular e exibir resultados dos investimentos', async () => {
    component.cdbForm = new FormGroup({
      valorMonetario: new FormControl(1000, Validators.required),
      mes: new FormControl(5, Validators.required),      
    });
    
    fixture.detectChanges();
  
    const button = fixture.nativeElement.querySelector('button');
    button.click();
    await fixture.whenStable();
    fixture.detectChanges();

    let resultado = component.cdbResultado;
    
    expect(resultado).not.toBeNull();
  });
});
