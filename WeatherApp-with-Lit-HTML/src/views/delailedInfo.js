import { html } from '../utils/lib.js';

export const detailedInfo = (data) => html`
<div class="grid grid-cols-2 gap-5 md:xl:2xl:grid-cols-3 place-content-center">
  ${data.map(infoCard)}
</div>
`;

const infoCard = (cardData) => html`
<div class="border-2 rounded-lg p-2">
  <h3 class="flex text-center items-center justify-center gap-2 rounded-lg text-2xl">
    <i class="${cardData.icon}"></i>
    ${cardData.text + ': '}
    ${cardData.value + '' + cardData.units}
  </h3>
</div>
`;