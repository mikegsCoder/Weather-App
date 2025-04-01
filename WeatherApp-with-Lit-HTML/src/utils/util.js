export function toggleTheme() {
  if (document.body.classList.contains('dark')) {
    document.body.classList.remove('dark');
    document.body.classList.add('light');
  } else if (document.body.classList.contains('light')) {
    document.body.classList.remove('light');
    document.body.classList.add('dark');
  }
};

export function createBodyData(data) {
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

  const bodyData = [
    pressure, 
    humidity, 
    visibility, 
  ];

  return bodyData;
}