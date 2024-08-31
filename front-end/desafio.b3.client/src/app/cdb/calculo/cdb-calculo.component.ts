import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Cdb } from '../models/cdb.model';
import { FormBaseComponent } from 'src/app/base-components/form-base.component';

@Component({
  selector: 'app-cdb-calculo',
  templateUrl: './cdb-calculo.component.html',
  styleUrls: ['./cdb-calculo.component.css']
})
export class CdbCalculoComponent extends FormBaseComponent implements OnInit {

  errors: any[] = [];
  cdbForm: FormGroup | any;
  cdb: Cdb | undefined;

  constructor(private fb: FormBuilder) { 
    super();

    // this.validationMessages = {
    //   email: {
    //     required: 'Informe o e-mail',
    //     email: 'Email inválido'
    //   },
    //   password: {
    //     required: 'Informe a senha',
    //     rangeLength: 'A senha deve possuir entre 6 e 15 caracteres'
    //   },
    //   confirmPassword: {
    //     required: 'Informe a senha novamente',
    //     rangeLength: 'A senha deve possuir entre 6 e 15 caracteres',
    //     equalTo: 'As senhas não conferem'
    //   }
    // };
  }

  ngOnInit(): void {
  }

  fazerCalculoCDB ()  {

  }

  processarSucesso(response : any) {

  }

  processarFalha(fail: any) {
    
  }

}
