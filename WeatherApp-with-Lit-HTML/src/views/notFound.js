import { html } from '../utils/lib.js';

export const notFound = (city) => html`
<div 
  class="border-2 rounded-lg p-2 flex text-center items-center justify-center gap-2 rounded-lg text-4xl"
  id="not-found"
>
  <i class="fa-regular fa-circle-xmark" id="err"></i>
  <div>
    <h3 class="flex text-center items-center justify-center gap-2 rounded-lg text-4xl">
      Invalid city name provided: <strong>${city}</strong>
    </h3>
    <h3 class="flex text-center items-center justify-center gap-2 rounded-lg text-3xl">
      Please enter a valid city name!
    </h3>
  </div>
</div>
`;
