import '../NotFound/NotFound.css'

import { useCityContext } from '../../../../contexts/CityContext';
import { FaRegCircleXmark } from "react-icons/fa6";

const NotFound = (): JSX.Element => {
  const { city } = useCityContext();

  return (
    <div className="border-2 rounded-lg p-2 flex text-center items-center justify-center gap-2 rounded-lg text-4xl" id="not-found">
      <FaRegCircleXmark size={120}/>
      <div>
        <h3 className="flex text-center items-center justify-center gap-2 rounded-lg text-4xl">
          Invalid city name provided: <strong>{city.name}</strong>
        </h3>
        <h3 className="flex text-center items-center justify-center gap-2 rounded-lg text-3xl">
          Please enter a valid city name!
        </h3>
      </div>
    </div>
  )
}

export default NotFound;