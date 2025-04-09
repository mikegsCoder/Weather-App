import { Component } from '@angular/core';

import { throwError } from 'rxjs';
import { catchError, finalize } from 'rxjs/operators';

import { WeatherService } from '../weather.service';

import IResponseData from '../../shared/interfaces/IResponseData';
import IBodyData from '../../shared/interfaces/IBodyData';
import IGeneralData from 'src/app/shared/interfaces/IGeneralData';

@Component({
  selector: 'app-body',
  templateUrl: './body.component.html',
  styleUrls: ['./body.component.css'],
})
export class BodyComponent {
  cityName: string;
  isLoading: boolean;
  inputChanges: boolean;
  notFound: boolean;
  onInit: boolean;
  weatherData: IResponseData;
  generalData: IGeneralData;
  bodyData: IBodyData[];

  constructor(private weatherService: WeatherService) {}

  ngOnInit(): void {
    this.isLoading = false;
    this.inputChanges = false;
    this.weatherData = {} as IResponseData;
    this.onInit = true;
  }

  onInputChange(e: any): void {
    // to implement
  }

  onGetWeatherData(): void {
    if (!this.cityName) return;

    this.onInit = false;
    this.isLoading = true;
    this.inputChanges = false;
    this.weatherData = {} as IResponseData;

    this.weatherService
      .getWeatherData(this.cityName)
      .pipe(
        catchError((err) => {
          console.log(err);
          this.weatherData = {} as IResponseData;

          return throwError('Invalid city name provided!');
        }),
        finalize(() => {
          this.isLoading = false;
        })
      )
      .subscribe(
        (data) => {
          console.log(data);
          this.weatherData = data;
          // to implement ...
        },
        (err) => {
          console.log(err);
        }
      );
  }
}
