import { render, nothing } from './utils/lib.js';

import { getWeatherData } from './utils/api.js';
import { toggleTheme } from './utils/util.js';

let city = '';

document.body.classList.add('light');

const root = document.getElementById('root');
