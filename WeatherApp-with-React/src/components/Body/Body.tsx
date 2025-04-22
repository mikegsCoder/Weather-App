import { useEffect, useState } from "react";

import { useCityContext } from "../../contexts/CityContext";

import IResponseData from "../../interfaces/IResponseData";

const Body = (): JSX.Element => {
  const { city } = useCityContext();

  const [notFound, setNotFound] = useState(false);
  const [data, setData] = useState({} as IResponseData);

  useEffect((): void => {
    setNotFound(false);
    setData({} as IResponseData);
  }, [city])

  return (
    <div className="">
      <div className="p-5 lg:p-10">
        <p>Body</p>
        {/* To implement ...  */}
      </div>
    </div>
  )
}

export default Body;