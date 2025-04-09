import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { apiKey } from '../shared/constants/appConstants';

import IResponseData from '../shared/interfaces/IResponseData';

@Injectable()
export class WeatherService {
  isLoaded = false;

  constructor(private http: HttpClient) {}

  getWeatherData(cityName: string): Observable<IResponseData> {
    const apiURL =
      "https://api.openweathermap.org/data/2.5/weather?q=" +
      cityName +
      "&appid=" +
      apiKey;

    return this.http.get<IResponseData>(apiURL);
  }
}
