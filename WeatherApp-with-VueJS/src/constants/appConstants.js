const env_apiKey = import.meta.env.VUE_APP_API_KEY;

const apiKey =  env_apiKey || 'Your-API-Key';
const logo = './img/logo.gif';
const baseUrl =  'https://api.openweathermap.org/data/2.5/';
const sourceCodeUrl = 'https://github.com/mikegsCoder/Weather-App/';
const dataProviderUrl = 'https://openweathermap.org/';
const vueJSUrl = 'https://vuejs.org/';

export {
  apiKey,
  logo,
  baseUrl,
  sourceCodeUrl,
  dataProviderUrl,
  vueJSUrl
};
