import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { catchError, map, Observable } from 'rxjs';
import { BaseService } from 'src/app/services/base.service';

import { Cdb } from './../models/cdb.model';
import { CdbResultado } from '../models/cdb.resultado.model';

@Injectable()
export class CdbService extends BaseService {
  
  constructor(private http: HttpClient) { super(); }
  
  fazerCalculo(cdb: Cdb) : Observable<CdbResultado> {
    let response = this.http
          .post(this.UrlServiceV1 + 'cdb', cdb, this.ObterHeaderJson())
          .pipe(
              map(this.extractData),
              catchError(this.serviceError));

      return response;
  }  
}
