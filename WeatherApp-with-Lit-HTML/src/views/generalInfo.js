import { html } from '../utils/lib.js';

export const generalInfo = (data) => html`
<div class="flex flex-col items-center justify-center">
  <h5 class="text-5xl flex items-center gap-5">
    <img
      class="object-contain"
      src="http://openweathermap.org/img/wn/${data?.weather[0]?.icon}@2x.png"
      alt="weather-icon"
    />
    <span>
      ${data?.name},<span> ${data?.sys?.country}</span>
    </span>
  </h5>
  <h2 class="text-3xl capitalize">
    ${data?.weather[0]?.description}
  </h2>
  <h6 class="text-7xl gap-2 mb-5 lg:grid">
  ${~~(data?.main?.temp - 273.15).toFixed(2)}°C
  <span class="text-lg text-3xl">
  Feels Like:
  ${' ' + (~~(data?.main?.feels_like - 273.15).toFixed(2) - 1)}°C
  </span>
  </h6>
</div>
<div id="details-container"></div>
`;
