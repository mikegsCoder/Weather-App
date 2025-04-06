import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { HeaderComponent } from './core/header/header.component';
import { FooterComponent } from './core/footer/footer.component';

import { BodyModule } from './body/body.module';
import { CoreModule } from './core/core.module';

@NgModule({
  declarations: [],
  providers: [],
  bootstrap: [
    HeaderComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    CoreModule,
    BodyModule
  ],
})
export class AppModule {}
