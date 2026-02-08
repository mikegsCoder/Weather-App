'use client'
import { usePathname, useRouter, useSearchParams } from 'next/navigation';

import { ReactElement, useEffect, useState, useTransition } from 'react';
import { useCityContext } from '@/contexts/CityContext';

import CityInput from './Partials/CityInput/';

import IResponseData from '@/interfaces/IResponseData';
import IBodyData from '@/interfaces/IBodyData';

import { createBodyData } from '@/utils/createBodyData';

const Body = (props: {
  data: IResponseData,
}): ReactElement => {
  const { city } = useCityContext();

  const router = useRouter();
  const pathname = usePathname();
  const searchParams = useSearchParams();

  const [isPending, startTransition] = useTransition();
  const [inputChanges, setInputChanges] = useState(false);
  const [notFound, setNotFound] = useState(false);
  const [infoCards, setInfoCards] = useState([] as ReactElement[]);

  useEffect((): void => {
    if (Object.keys(props.data).length == 0) {
      setNotFound(true);
    } else {
      setNotFound(false);
    }

    const bodyData: IBodyData[] = createBodyData(props.data);
   
    //To implement infoCards
  }, [props.data]);

  return (
    <div className="">
      <div className="p-5 lg:p-10">
        <h2>Weather Data</h2>
      </div>
    </div>
  )
}

export default Body;