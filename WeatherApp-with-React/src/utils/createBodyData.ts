import IBodyData from "../interfaces/IBodyData";
import IResponseData from "../interfaces/IResponseData";

import { 
  BsDropletHalf, 
  BsSpeedometer, 
  BsEye, 
  BsCompass, 
  BsCloud, 
  BsWind 
} from "react-icons/bs";

export const createBodyData = (data: IResponseData): IBodyData[] => {
    const pressure: IBodyData = {
      icon: BsSpeedometer,
      value: data?.main?.pressure,
      units: 'hPa',
      text: 'Pressure'
    };
    const humidity: IBodyData = {
      icon: BsDropletHalf,
      value: data?.main?.humidity,
      units: '%',
      text: 'Humidity'
    };
    const visibility: IBodyData = {
      icon: BsEye,
      value: data?.visibility / 1000,
      units: 'km',
      text: 'Visibility'
    };
    const windSpeed: IBodyData = {
      icon: BsWind,
      value: data?.wind?.speed,
      units: 'km/h',
      text: 'Wind Speed'
    };
    const windDirection: IBodyData = {
      icon: BsCompass,
      value: data?.wind?.deg,
      units: 'deg',
      text: 'Wind Direction'
    };
    const cloudiness: IBodyData = {
      icon: BsCloud,
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