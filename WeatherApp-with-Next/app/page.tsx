'use server'
import logo from '../public/logo.gif';
import { sourceCodeUrl, dataProviderUrl, nextUrl } from '@/constants/appConstants';
import { getWeatherData } from '@/dataProviders/weather';
import { CityContextProvider } from '@/contexts/CityContext';

import Header from '@/components/Header';
import Footer from '@/components/Footer';
import Body from '@/components/Body';
import ErrorBoundary from '@/components/ErrorBoundary';

import IResponseData from '@/interfaces/IResponseData';

export default async function Home({ searchParams }: { searchParams: { city?: string }}) {
  let data: IResponseData;
  const { city } = await searchParams;

  city 
    ? data = await getWeatherData(city) 
    : data = {} as IResponseData;

  return (
    <div id="root">
      <ErrorBoundary>
        <CityContextProvider>
          <Header logo={logo} nextUrl={nextUrl} />
          <Body data={data} />
          <Footer sourceCode={sourceCodeUrl} dataProviderUrl={dataProviderUrl} />
        </CityContextProvider>
      </ErrorBoundary>
    </div>
  );
}
