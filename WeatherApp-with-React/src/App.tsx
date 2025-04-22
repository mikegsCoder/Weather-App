import "./assets/css/styles.css";

import logo from "./assets/img/logo.gif";
import { sourceCodeUrl, dataProviderUrl, reactTSUrl } from "./constants/appConstants";

import { CityContextProvider } from "./contexts/CityContext";

import ErrorBoundary from "./components/ErrorBoundary/";
import Header from "./components/Header";
import Body from "./components/Body"
import Footer from "./components/Footer";

function App(): JSX.Element {

  return (
    <ErrorBoundary>
      <CityContextProvider>
        <Header logo={logo} reactTSUrl={reactTSUrl} />
        <Body />
        <Footer sourceCode={sourceCodeUrl} dataProviderUrl={dataProviderUrl} />
      </CityContextProvider>
    </ErrorBoundary>
  );
}

export default App;
