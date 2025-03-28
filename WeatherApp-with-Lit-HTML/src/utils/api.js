import { apiKey, baseUrl } from './appConstants.js'

async function request(cityName) {
  const url = baseUrl + 'weather?q=' + cityName + "&appid=" + apiKey;
  
  try {
    const response = await fetch(url);

    if (response.ok != true) {
      const error = await response.json();
      throw new Error(error.message);
    }

    try {
      return await response.json();
    } catch (err) {
      return response;
    }

  } catch (err) {
    console.log(err.message);
    return null;
  }
};

export async function getWeatherData(cityName) {
  return request(cityName);
}
