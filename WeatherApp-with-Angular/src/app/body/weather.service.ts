import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { apiKey } from '../shared/constants/appConstants';

import IResponseData from '../shared/interfaces/IResponseData';
import IGeneralData from '../shared/interfaces/IGeneralData';
import IBodyData from '../shared/interfaces/IBodyData';

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

  getBodyData(data: IResponseData): IBodyData[] {
    const pressure: IBodyData = {
      icon: 'fa-solid fa-gauge-high',
      value: data?.main?.pressure,
      units: 'hPa',
      text: 'Pressure'
    };
    const humidity: IBodyData = {
      icon: 'fa-solid fa-droplet',
      value: data?.main?.humidity,
      units: '%',
      text: 'Humidity'
    };
    const visibility: IBodyData = {
      icon: 'fa-solid fa-eye',
      value: data?.visibility / 1000,
      units: 'km',
      text: 'Visibility'
    };
    const windSpeed: IBodyData = {
      icon: 'fa-solid fa-wind',
      value: data?.wind?.speed,
      units: 'km/h',
      text: 'Wind Speed'
    };
    const windDirection: IBodyData = {
      icon: 'fa-solid fa-compass',
      value: data?.wind?.deg,
      units: 'deg',
      text: 'Wind Direction'
    };
    const cloudiness: IBodyData = {
      icon: 'fa-solid fa-cloud',
      value: data?.clouds?.all,
      units: '%',
      text: 'Cloudiness'
    };

    const bodyData: IBodyData[] = [
      pressure, 
      humidity, 
      visibility, 
      windSpeed, 
      windDirection, 
      cloudiness
    ];

    return bodyData;
  }
}
