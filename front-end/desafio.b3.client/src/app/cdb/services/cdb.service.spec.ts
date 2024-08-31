import { TestBed } from '@angular/core/testing';
import { HttpClientModule } from '@angular/common/http';
import { Observable, Observer } from 'rxjs';

import { Cdb } from '../models/cdb.model';
import { CdbResultado } from '../models/cdb.resultado.model';
import { CdbService } from './cdb.service';

const cdbFake: Cdb = {
  valorMonetario: 100.0,
  mes: 2
}

const cdbResultadoFake: CdbResultado = {
  bruto: 101.95344784,
  liquido: 101.66043066399999
}

function createResponse(body: any){
  return Observable.create((observer: Observer<any>) => {
    observer.next(body);
  });
}

describe(' Teste funcionalidade do servico CdbService', async () => {
  let service: CdbService;
  let cdb: Cdb;

  beforeEach(() => {
    const bed = TestBed.configureTestingModule({      
      imports: [       
        HttpClientModule  
      ],
      providers: [
        CdbService
      ]
    });
    service = bed.inject(CdbService);
  });

  it('Teste deve criar service CdbService', () => {
    expect(service).toBeTruthy();
  });

  it('Teste deve executar o metodo fazerCalculo', async () => {
    let observerResultadoFake = createResponse(cdbResultadoFake);

    spyOn(service, 'fazerCalculo').and.returnValue(observerResultadoFake);

    let result = service.fazerCalculo(cdbFake);

    expect(result).toEqual(observerResultadoFake);
  });
});


    // component.cdbResultado = Object.assign(
    //   {}, 
    //   component.cdbResultado, 
    //   {"bruto": 101.95344784,"liquido": 101.66043066399999}
    // ); 
