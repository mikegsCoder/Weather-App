export function createGeneralData(data) {
  const generalData = {
    icon: data.weather[0].icon,
    name: data.name, 
    country: data.sys.country, 
    description: data.weather[0].description, 
    temp: ~~(data.main.temp - 273.15).toFixed(2), 
    feels_like: ' ' + ~~(data.main.feels_like - 273.15).toFixed(2) - 1
  };

  return generalData;
}