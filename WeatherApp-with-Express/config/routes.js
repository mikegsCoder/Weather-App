const homeController = require('../controllers/homeController');
const weatherController = require('../controllers/weatherController');

module.exports = (app) => {
  app.use('/', homeController);
  app.use('/weather', weatherController);
};