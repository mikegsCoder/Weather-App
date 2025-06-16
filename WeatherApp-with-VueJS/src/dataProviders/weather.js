import { axiosInstance } from './axios';
import { apiKey } from '../constants/appConstants';

const env_apiKey = import.meta.env.API_KEY;

export async function getWeatherData(cityName) {
  const apiURL = `weather?q=${cityName}&appid=${env_apiKey || apiKey}`;

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