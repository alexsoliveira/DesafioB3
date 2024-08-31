import { AppRoutingModule } from './app-routing.module';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { AppComponent } from './app.component';
import { CdbModule } from './cdb/cdb.module';

@NgModule({
  declarations: [
    AppComponent    
  ],
  imports: [
    BrowserModule,    
    AppRoutingModule,
    CdbModule,    
    NgbModule    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
