import "./assets/css/styles.css";

import logo from "./assets/img/logo.gif";
import { sourceCodeUrl, dataProviderUrl, reactTSUrl } from "./constants/appConstants";

import ErrorBoundary from "./components/ErrorBoundary/";
import Header from "./components/Header";
import Footer from "./components/Footer";

function App(): JSX.Element {

  return (
    <ErrorBoundary>
      <Header logo={logo} reactTSUrl={reactTSUrl} />
      <h1>Weather App with React</h1>
      <Footer sourceCode={sourceCodeUrl} dataProviderUrl={dataProviderUrl} />
    </ErrorBoundary>
  );
}

export default App;
