import Link from 'next/link';
import { ReactElement } from 'react';

import './Footer.css';

const Footer = (props: {
  sourceCode: string,
  dataProviderUrl: string
}): ReactElement => {
  return (
    <>
      <hr className='hr-bottom' />
      <Link
        href={props.dataProviderUrl}
        target={"_blank"}
        rel="noreferrer"
        className="text-3xl font-semibold absolute bottom-5 left-10"
      >
        Data Provider
      </Link>
    </>
  )
}

export default Footer;