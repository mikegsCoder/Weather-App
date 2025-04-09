import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BodyComponent } from './body/body.component';

import { WeatherService } from './weather.service';

@NgModule({
  declarations: [
    BodyComponent
  ],
  imports: [
    CommonModule
  ],
  providers: [
    WeatherService
  ]
})
export class BodyModule {}
