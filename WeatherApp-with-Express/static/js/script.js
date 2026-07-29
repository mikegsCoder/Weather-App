document.body.classList.add('light');

// add event listeners:
document.getElementById('checkbox').addEventListener('click', toggleTheme);
document.getElementById('input').addEventListener('input', handleInputChange);
document.getElementById('inputForm').addEventListener('submit', handleSubmit);

function handleInputChange(e) {
  city = e.target.value;
  clearBody();
}

function clearBody() {
  const weatherInfo = document.getElementById('weather-info');
  if (weatherInfo) weatherInfo.style.display = 'none';

  const notFound = document.getElementById('not-found');
  if (notFound) notFound.style.display = 'none';
}

function toggleTheme() {
  if (document.body.classList.contains('dark')) {
    document.body.classList.remove('dark');
    document.body.classList.add('light');
  } else if (document.body.classList.contains('light')) {
    document.body.classList.remove('light');
    document.body.classList.add('dark');
  }
}
