import { CdbResultado } from './../models/cdb.resultado.model';
import { AfterViewInit, Component, ElementRef, OnInit, ViewChildren } from '@angular/core';
import { FormBuilder, FormControl, FormControlName, FormGroup, Validators } from '@angular/forms';

import { Cdb } from '../models/cdb.model';
import { FormBaseComponent } from 'src/app/base-components/form-base.component';
import { CdbService } from '../services/cdb.service';

@Component({
  selector: 'app-cdb-calculo',
  templateUrl: './cdb-calculo.component.html'
})
export class CdbCalculoComponent extends FormBaseComponent implements OnInit, AfterViewInit {

  @ViewChildren(FormControlName, { read: ElementRef }) formInputElements: ElementRef[] | any;
  
  errors: any[] = [];
  cdbForm: FormGroup | any;
  cdb: Cdb | any;
  cdbResultado: CdbResultado | any; 

  valorMonetario: number | undefined;
  mes: number | undefined;

  constructor(private fb: FormBuilder,
    private cdbService: CdbService,    
  ) { 
    super();

    
    this.validationMessages = {
      valorMonetario: {
        required: 'Informe o cdb para o calculo',
        pattern: 'O mes deve possuir entre 6 e 15 caracteres'
      },
      mes: {
        required: 'Informe o mes para o calculo',
        pattern: 'O mes deve possuir entre 6 e 15 caracteres'
      },
    };

    super.configurarMensagensValidacaoBase(this.validationMessages);
  }

  ngOnInit(): void {

    let valorCdb = new FormControl('', [Validators.required, Validators.pattern('')]);
    let valorMes = new FormControl('', [Validators.required, Validators.pattern('')]);

    this.cdbForm = this.fb.group({
      valorMonetario: valorCdb,
      mes: valorMes,    
    });
  }

  ngAfterViewInit(): void {
    super.configurarValidacaoFormularioBase(this.formInputElements, this.cdbForm);
  }

  fazerCalculoCDB ()  {
    if (this.cdbForm.dirty && this.cdbForm.valid) {
      this.cdb = Object.assign({}, this.cdb, this.cdbForm.value);

      this.cdbService.fazerCalculo(this.cdb)
        .subscribe(
          sucesso => { this.processarSucesso(sucesso) },
          falha => { this.processarFalha(falha) }
        );

      this.mudancasNaoSalvas = false;
    }
  }

  processarSucesso(response : any) {
    this.cdbForm.reset();
    this.errors = [];
    
    this.cdbResultado = Object.assign({}, this.cdbResultado, response);    
    console.log(this.cdbResultado);
  }

  processarFalha(fail: any) {
    this.errors = fail.error.errors;    
  }

  validarCampoCDB(valorCDB: any) {
    return !(valorCDB == undefined || valorCDB == null || valorCDB < 0);
  }


  validarCampoMes(valorMes: any) {
    return !(valorMes == undefined || valorMes == null || valorMes < 0);
  }

}
