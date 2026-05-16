// Write your JavaScript code.

document.body.classList.add('light');

const input = document.getElementById('cityInput');

function toggleTheme() {
    if (document.body.classList.contains('dark')) {
        document.body.classList.remove('dark');
        document.body.classList.add('light');
    } else if (document.body.classList.contains('light')) {
        document.body.classList.remove('light');
        document.body.classList.add('dark');
    }
};

function clearBody() {
    const weatherInfo = document.getElementById('weather-info');
    if (weatherInfo) weatherInfo.style.display = 'none';

    const notFound = document.getElementById('not-found');
    if (notFound) notFound.style.display = 'none';
}