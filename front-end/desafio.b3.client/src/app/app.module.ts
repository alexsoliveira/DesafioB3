import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { CdbModule } from './cdb/cdb.module';

@NgModule({
  declarations: [
    AppComponent    
  ],
  imports: [
    BrowserModule, 
    HttpClientModule,
    AppRoutingModule,
    CdbModule    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
