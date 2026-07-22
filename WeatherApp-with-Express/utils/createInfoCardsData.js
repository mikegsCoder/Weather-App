export function createInfoCardsData(data) {
  const pressure = {
    icon: 'fa-solid fa-gauge-high',
    value: data?.main?.pressure + ' ' + 'hPa',
    text: 'Pressure' + ': '
  };
  const humidity = {
    icon: 'fa-solid fa-droplet',
    value: data?.main?.humidity + ' ' + '%',
    text: 'Humidity' + ': '
  };
  const visibility = {
    icon: 'fa-solid fa-eye',
    value: (data?.visibility / 1000) + ' ' + 'km',
    text: 'Visibility' + ': '
  };
  const windSpeed = {
    icon: 'fa-solid fa-wind',
    value: data?.wind?.speed + ' ' + 'km/h',
    text: 'Wind Speed' + ': '
  };
  const windDirection = {
    icon: 'fa-solid fa-compass',
    value: data?.wind?.deg + ' ' + 'deg',
    text: 'Wind Direction' + ': '
  };
  const cloudiness = {
    icon: 'fa-solid fa-cloud',
    value: data?.clouds?.all + ' ' + '%',
    text: 'Cloudiness' + ': '
  };

  const infoCardsData = [
    pressure, 
    humidity, 
    visibility, 
    windSpeed, 
    windDirection, 
    cloudiness
  ];

  return infoCardsData;
}