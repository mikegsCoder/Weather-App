const router = require('express').Router();
const crypto = require('crypto');

const { getWeatherData } = require('../services/weather');
const { createGeneralData } = require('../utils/createGeneralData');
const { createInfoCardsData } = require('../utils/createInfoCardsData');

const jobs = {};

router.post('/', (req, res) => {
  const id = crypto.randomUUID();

  jobs[id] = {
    status: 'loading',
    data: null
  };

  // starting async task:
  loadWeather(id, req.body.city);

  res.redirect('/weather/' + id);
});

async function loadWeather(id, city) {
  // To implement
}

module.exports = router;