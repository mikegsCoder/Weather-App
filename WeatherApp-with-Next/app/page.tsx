'use server'
import logo from '../public/logo.gif';
import { sourceCodeUrl, dataProviderUrl, nextUrl } from '@/constants/appConstants';
import { CityContextProvider } from '@/contexts/CityContext';

import Header from '@/components/Header';
import Footer from '@/components/Footer';
import ErrorBoundary from '@/components/ErrorBoundary';

export default async function Home() {

  return (
    <div id="root">
      <ErrorBoundary>
        <CityContextProvider>
          <Header logo={logo} nextUrl={nextUrl} />
          
          <Footer sourceCode={sourceCodeUrl} dataProviderUrl={dataProviderUrl} />
        </CityContextProvider>
      </ErrorBoundary>
    </div>
  );
}
