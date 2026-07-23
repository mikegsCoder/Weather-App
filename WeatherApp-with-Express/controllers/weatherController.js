const router = require('express').Router();
const crypto = require('crypto');

const { getWeatherData } = require('../services/weather');
const { createGeneralData } = require('../utils/createGeneralData');
const { createInfoCardsData } = require('../utils/createInfoCardsData');

// To implement

module.exports = router;