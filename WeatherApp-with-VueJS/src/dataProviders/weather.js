import { axiosInstance } from './axios';
import { apiKey } from '../constants/appConstants';

export async function getWeatherData(cityName) {
  const apiURL = `weather?q=${cityName}&appid=${apiKey}`;

  try {
    const res = await axiosInstance.get(apiURL);
    console.log("response: ", res.data);
    return res.data;
  }
  catch (err) {
    console.log("err: ", err);
    return null;
  }
}