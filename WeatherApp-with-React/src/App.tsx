import "./assets/css/styles.css";

import logo from "./assets/img/logo.gif";
import { reactTSUrl } from "./constants/appConstants";

import ErrorBoundary from "./components/ErrorBoundary/";
import Header from "./components/Header";

function App(): JSX.Element {

  return (
    <ErrorBoundary>
      <Header logo={logo} reactTSUrl={reactTSUrl} />
      <h1>Weather App with React</h1>
    </ErrorBoundary>
  );
}

export default App;
