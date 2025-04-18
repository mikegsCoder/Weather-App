import ErrorBoundary from "./components/ErrorBoundary/";


function App(): JSX.Element {

  return (
    <ErrorBoundary>
      <h1>Weather App with React</h1>
    </ErrorBoundary>
  );
}

export default App;
