import { render, nothing } from './utils/lib.js';

import { getWeatherData } from './utils/api.js';
import { toggleTheme, createBodyData } from './utils/util.js';

import { loader } from './views/loader.js';
import { notFound } from './views/notFound.js';
import { generalInfo } from './views/generalInfo.js';
import { detailedInfo } from './views/delailedInfo.js';

let city = '';

document.body.classList.add('light');

const root = document.getElementById('root');

// add event listeners:
document.getElementById('checkbox').addEventListener('click', toggleTheme);
document.getElementById('input').addEventListener('input', handleInputChange);
document.getElementById('btn').addEventListener('click', handleSearch);

function handleInputChange(e) {
  city = e.target.value;
  render(nothing, root);
}

async function handleSearch() {
  if(!city) return;
  
  render(loader(), root);
  const data = await getWeatherData(city);
  
  if (data) {
    console.log(data);
    render(generalInfo(data), root);

    const detailsContainer = document.getElementById('details-container');
    const bodyData = createBodyData(data);
    render(detailedInfo(bodyData), detailsContainer);
  } else {
    console.log('No data!');
    render(notFound(city), root);
  }
}
