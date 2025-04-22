import { MouseEventHandler } from "react";
import { useCityContext } from "../../../../contexts/CityContext";

const CityInput = (props: {
  handleSearch: MouseEventHandler<HTMLButtonElement>
}): JSX.Element => {
  const { city, setCity } = useCityContext();

  const handleChangeInput = (e: any): void => {
    setCity({ name: e.target.value });
  };

  return (
    <div className="h-56 flex flex-col items-center justify-center ">
      <div className="text-black grid gap-5">
        <input
          type="text"
          className="text-2xl bg-transparent outline-none border-b-2 w-96 h-12 pl-2 pr-2 capitalize"
          placeholder="Enter Your City Name"
          value={city?.name}
          onChange={handleChangeInput}
        />
        <button
          className="bn3 text-2xl"
          type="submit"
          onClick={props.handleSearch}
        >
          Search
        </button>
      </div>
    </div>
  )
}

export default CityInput;