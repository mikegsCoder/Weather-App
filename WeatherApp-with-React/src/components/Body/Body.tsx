import { useEffect, useState } from "react";

import { useCityContext } from "../../contexts/CityContext";

import CityInput from "./Partials/CityInput/";

import IResponseData from "../../interfaces/IResponseData";

const Body = (): JSX.Element => {
  const { city } = useCityContext();

  const [notFound, setNotFound] = useState(false);
  const [data, setData] = useState({} as IResponseData);

  useEffect((): void => {
    setNotFound(false);
    setData({} as IResponseData);
  }, [city])

  const handleSearch = async (): Promise<void> => {
    // to implement ...
  };

  return (
    <div className="">
      <div className="p-5 lg:p-10">
        <CityInput  handleSearch={handleSearch}/>
        {/* To implement ...  */}
      </div>
    </div>
  )
}

export default Body;