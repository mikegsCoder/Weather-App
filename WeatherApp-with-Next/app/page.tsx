'use server'
import logo from '../public/logo.gif';
import { sourceCodeUrl, dataProviderUrl, nextUrl } from '@/constants/appConstants';
import { CityContextProvider } from '@/contexts/CityContext';

import Header from '@/components/Header';
import ErrorBoundary from '@/components/ErrorBoundary';

export default async function Home() {

  return (
    <div id="root">
      <ErrorBoundary>
        <CityContextProvider>
          <Header logo={logo} nextUrl={nextUrl} />
          <h2>Weather App</h2>
        </CityContextProvider>
      </ErrorBoundary>
    </div>
  );
}
