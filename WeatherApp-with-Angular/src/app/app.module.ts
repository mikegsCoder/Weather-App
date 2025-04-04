import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { CoreModule } from './core/core.module';

@NgModule({
  declarations: [],
  providers: [],
  bootstrap: [],
  imports: [
    BrowserModule,
    HttpClientModule,
    CoreModule
  ],
})
export class AppModule {}
