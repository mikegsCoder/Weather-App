export const createBodyData = (data) => {
    const pressure = {
      icon: 'fa-solid fa-gauge-high',
      value: data?.main?.pressure,
      units: 'hPa',
      text: 'Pressure'
    };
    const humidity = {
      icon: 'fa-solid fa-droplet',
      value: data?.main?.humidity,
      units: '%',
      text: 'Humidity'
    };
    const visibility = {
      icon: 'fa-solid fa-eye',
      value: data?.visibility / 1000,
      units: 'km',
      text: 'Visibility'
    };
    const windSpeed = {
      icon: 'fa-solid fa-wind',
      value: data?.wind?.speed,
      units: 'km/h',
      text: 'Wind Speed'
    };
    const windDirection = {
      icon: 'fa-solid fa-compass',
      value: data?.wind?.deg,
      units: 'deg',
      text: 'Wind Direction'
    };
    const cloudiness = {
      icon: 'fa-solid fa-cloud',
      value: data?.clouds?.all,
      units: '%',
      text: 'Cloudiness'
    };

    const bodyData = [
      pressure, 
      humidity, 
      visibility, 
      windSpeed, 
      windDirection, 
      cloudiness
    ];

    return bodyData;
}