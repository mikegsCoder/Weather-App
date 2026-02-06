import { axiosInstance } from './axios';
import { AxiosResponse } from 'axios';

import { apiKey } from '@/constants/appConstants';
import IResponseData from '@/interfaces/IResponseData';

export async function getWeatherData(cityName: string): Promise<IResponseData> {
  const apiURL: string = `weather?q=${cityName}&appid=${apiKey}`;

  try {
    const res: AxiosResponse<any, any> = await axiosInstance.get(apiURL);
    console.log('response: ', res.data);
    return res.data;
  }
  catch (err) {
    console.log('err: ', err);
    return {} as IResponseData;
  }
}