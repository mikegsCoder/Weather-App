'use server'

import ErrorBoundary from '@/components/ErrorBoundary';

export default async function Home() {

  return (
    <div id="root">
      <ErrorBoundary>
        <h2>Weather App</h2>
      </ErrorBoundary>
    </div>
  );
}
