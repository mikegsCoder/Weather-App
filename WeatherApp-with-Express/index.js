const express = require('express');

const port = 3000;
const expressConfig = require('./config/express');

start();

function start() {
  const app = express();

  expressConfig(app);
  
  app.listen(port, () =>
    console.log(`Application startted at http://localhost:${port}`));
}
