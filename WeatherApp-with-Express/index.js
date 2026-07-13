const express = require('express');

const { port } = require('./config');
const expressConfig = require('./config/express');
const routesConfig = require('./config/routes');

start();

function start() {
  const app = express();

  expressConfig(app);
  routesConfig(app);
  
  app.listen(port, () =>
    console.log(`Application startted at http://localhost:${port}`));
}
