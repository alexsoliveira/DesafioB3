import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { CdbRoutingModule } from './cdb.route';

import { CdbAppComponent } from './cdb.app.component';
import { CdbCalculoComponent } from './calculo/cdb-calculo.component';

@NgModule({
  declarations: [
    CdbAppComponent,
    CdbCalculoComponent    
  ],
  imports: [
    CommonModule,
    RouterModule,
    CdbRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule  
  ],
  providers: [ ]
})
export class CdbModule { }
