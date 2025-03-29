import { render, nothing } from './utils/lib.js';

import { getWeatherData } from './utils/api.js';
import { toggleTheme } from './utils/util.js';

let city = '';

document.body.classList.add('light');

const root = document.getElementById('root');

// add event listeners:
document.getElementById('checkbox').addEventListener('click', toggleTheme);
document.getElementById('input').addEventListener('input', handleInputChange);
document.getElementById('btn').addEventListener('click', handleSearch);

function handleInputChange(e) {}

async function handleSearch() {}
