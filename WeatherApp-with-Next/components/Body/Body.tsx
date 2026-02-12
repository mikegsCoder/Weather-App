'use client'
import { usePathname, useRouter, useSearchParams } from 'next/navigation';

import { ReactElement, useEffect, useState, useTransition } from 'react';
import { useCityContext } from '@/contexts/CityContext';

import CityInput from './Partials/CityInput/';
import GeneralInfo from './Partials/GeneralInfo/';
import InfoCard from './Partials/InfoCard/';

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
    const cards: ReactElement[] = bodyData.map(data => <InfoCard data={data} key={bodyData.indexOf(data)}/>);
    setInfoCards(cards);
  }, [props.data]);

  useEffect((): void => {
    setInputChanges(true);
  }, [city]);

  const handleSearch = async (): Promise<void> => {
    if (!city.name) return;

    setNotFound(true);
    setInputChanges(false);

    const updatedSearchParams = new URLSearchParams(searchParams);
    updatedSearchParams.set("city", city.name);

    startTransition(() => {
      router.replace(`${pathname}?${updatedSearchParams.toString()}`);
    });
  };

  const weatherInfo: ReactElement = (
    <>
      <div className="text-center" role="status">
        <div className="grid">
          <GeneralInfo data={props.data} />
          <div className="grid grid-cols-2 gap-5 md:xl:2xl:grid-cols-3 place-content-center">
            {infoCards}
          </div>
        </div>
      </div>
    </>
  )

  return (
    <div className="">
      <div className="p-5 lg:p-10">
        <h2>Weather Data</h2>
      </div>
    </div>
  )
}

export default Body;