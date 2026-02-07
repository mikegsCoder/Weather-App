'use client'
import { ReactElement } from 'react';
import { useCityContext } from '@/contexts/CityContext';

import IResponseData from '@/interfaces/IResponseData';

const Body = (props: {
  data: IResponseData,
}): ReactElement => {
  const { city } = useCityContext();

  return (
    <div className="">
      <div className="p-5 lg:p-10">
        <h2>Weather Data</h2>
      </div>
    </div>
  )
}

export default Body;