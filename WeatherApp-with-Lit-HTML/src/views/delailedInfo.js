import { html } from '../utils/lib.js';

export const detailedInfo = (data) => html`
<div class="grid grid-cols-2 gap-5 md:xl:2xl:grid-cols-3 place-content-center">
  ${data.map(infoCard)}
</div>
`;

const infoCard = (cardData) => html``;