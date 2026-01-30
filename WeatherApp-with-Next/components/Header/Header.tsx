import Link from 'next/link';
import Image, { StaticImageData } from 'next/image';
import { ReactElement } from 'react';
import { FiMoon, FiSun } from 'react-icons/fi';
import ToggleTheme from './Partials/ToggleTheme';

import './Header.css';

const Header = (props: {
  logo: StaticImageData,
  nextUrl: string
}): ReactElement => {
  return (
    <>
      <Link
        href={props.nextUrl}
        target={"_blank"}
        rel="noreferrer"
        className="text-3xl flex items-center gap-2 absolute top-2 left-10 font-semibold"
      >
        <Image src={props.logo} className="w-[120px]" id="logo" alt="logo" />
        Weather App with NEXT.JS
      </Link>
      <ToggleTheme/>
    </>
  )
}

export default Header;