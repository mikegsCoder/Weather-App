import { useEffect, useState } from "react";

import { useCityContext } from "../../contexts/CityContext";

import CityInput from "./Partials/CityInput/";
import GeneralInfo from "./Partials/GeneralInfo/";
import InfoCard from "./Partials/InfoCard/";
import Loader from "./Partials/Loader"
import NotFound from "./Partials/NotFound";

import IResponseData from "../../interfaces/IResponseData";
import IBodyData from "../../interfaces/IBodyData";

import { getWeatherData } from "../../dataProviders/weather";
import { createBodyData } from "../../utils/createBodyData";

const Body = (): JSX.Element => {
  const { city } = useCityContext();

  const [loading, setLoading] = useState(false);
  const [notFound, setNotFound] = useState(false);
  const [data, setData] = useState({} as IResponseData);
  const [infoCards, setInfoCards] = useState([] as JSX.Element[]);

  useEffect((): void => {
    const bodyData: IBodyData[] = createBodyData(data);
    const cards: JSX.Element[] = bodyData.map(data => <InfoCard data={data} key={bodyData.indexOf(data)}/>);
    setInfoCards(cards);
  }, [data]);

  useEffect((): void => {
    setNotFound(false);
    setData({} as IResponseData);
  }, [city])

  const handleSearch = async (): Promise<void> => {
    if (!city?.name) return;
    setLoading(true);
    const currentData: IResponseData | null = await getWeatherData(city?.name);
    if (currentData) {
      setData(currentData);
      setLoading(false);
      setNotFound(false);
    } else {
      setLoading(false);
      setNotFound(true);
    }
  };

  return (
    <div className="">
      <div className="p-5 lg:p-10">
        <CityInput  handleSearch={handleSearch}/>
        { loading ? <Loader/> : null }
        { !loading && notFound ? <NotFound/> : null }
        {/* To implement ...  */}
      </div>
    </div>
  )
}

export default Body;