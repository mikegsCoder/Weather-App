'use client'
import { usePathname, useRouter, useSearchParams } from 'next/navigation';

import { ReactElement, useState, useTransition } from 'react';
import { useCityContext } from '@/contexts/CityContext';

import IResponseData from '@/interfaces/IResponseData';

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

  return (
    <div className="">
      <div className="p-5 lg:p-10">
        <h2>Weather Data</h2>
      </div>
    </div>
  )
}

export default Body;