import './Footer.css';

const Footer = (props: {
  sourceCode: string,
  dataProviderUrl: string
}): JSX.Element => {
  return (
    <>
      <hr className='hr-bottom' />
      <a
        href={props.dataProviderUrl}
        target={"_blank"}
        rel="noreferrer"
        className="text-3xl font-semibold absolute bottom-5 left-10"
      >
        Data Provider
      </a>
      <a
        href={props.sourceCode}
        target={"_blank"}
        rel="noreferrer"
        className="text-3xl font-semibold absolute bottom-5 right-10"
      >
        Source Code
      </a>
    </>
  )
}

export default Footer;