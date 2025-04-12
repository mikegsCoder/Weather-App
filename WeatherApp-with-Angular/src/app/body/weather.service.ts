import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { apiKey } from '../shared/constants/appConstants';

import IResponseData from '../shared/interfaces/IResponseData';
import IGeneralData from '../shared/interfaces/IGeneralData';

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

  getGeneralData(data: IResponseData): IGeneralData {
    return {
      imgUrl: `http://openweathermap.org/img/wn/${data.weather[0].icon}@2x.png`,
      name: data.name,
      country: data.sys.country,
      description: data.weather[0].description,
      temp: ~~(data.main.temp - 273.15).toFixed(2),
      feels_like: ~~(data.main.feels_like - 273.15).toFixed(2) - 1
    }
  }
}
