const express = require('express');

const { port } = require('./config');
const expressConfig = require('./config/express');

start();

function start() {
  const app = express();

  expressConfig(app);
  
  app.listen(port, () =>
    console.log(`Application startted at http://localhost:${port}`));
}
