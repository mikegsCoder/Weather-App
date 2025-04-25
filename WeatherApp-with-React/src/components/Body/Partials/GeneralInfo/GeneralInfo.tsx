import IResponseData from "../../../../interfaces/IResponseData";

const GeneralInfo = (props: {
  data: IResponseData
}): JSX.Element => {
  return (
    <>
      <div className="flex flex-col items-center justify-center">
        <h5 className="text-5xl flex items-center gap-5">
          <img
            className="object-contain"
            src={`http://openweathermap.org/img/wn/${props.data?.weather[0]?.icon}@2x.png`}
            alt="weather-icon"
          />
          <span>
            {props.data?.name},<span> {props.data?.sys?.country}</span>
          </span>
        </h5>
        <h2 className="text-3xl capitalize">
          {props.data?.weather[0]?.description}
        </h2>
      </div>
      <h6 className="text-7xl gap-2 mb-5 lg:grid">
        {~~(props.data?.main?.temp - 273.15).toFixed(2)}°C
        <span className="text-lg text-3xl">
          Feels Like:
          {' ' + (~~(props.data?.main?.feels_like - 273.15).toFixed(2) - 1)}°C
        </span>
      </h6>
    </>
  )
}

export default GeneralInfo;