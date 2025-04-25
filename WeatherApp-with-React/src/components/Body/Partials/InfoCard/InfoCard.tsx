import IBodyData from "../../../../interfaces/IBodyData";

const InfoCard = (props: {
  data: IBodyData
}): JSX.Element => {

  return (
    <div className="border-2 rounded-lg p-2">
      <h3 className="flex text-center items-center justify-center gap-2 rounded-lg text-2xl">
        <props.data.icon size={30} />
        {props.data.text + ': '}
        {props.data.value}{props.data.units}
      </h3>
    </div>
  )
}

export default InfoCard;