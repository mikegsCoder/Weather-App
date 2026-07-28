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

router.get('/:id', (req, res) => {
  const job = jobs[req.params.id];

  if (!job) {
    return res.status(404).send('Job not found');
  }

  // still loading:
  if (job.status === 'loading') {
    return res.render('weather', {
      loading: true
    });
  }

  // no data:
  if (!job.data) {
    return res.render('partials/notFound');
  }

  // success:
  const data = job.data;
  console.log(data);

  const generalData = createGeneralData(data);
  const infoCardsData = createInfoCardsData(data);

  const weatherData = {
    generalData,
    infoCardsData
  };

  res.render('weather', {
    loading: false,
    data: weatherData
  });
});

async function loadWeather(id, city) {
  const data = await getWeatherData(city);

  jobs[id] = {
    status: 'done',
    data
  };
}

module.exports = router;