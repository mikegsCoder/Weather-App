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
      <h2>Header</h2>
      <ToggleTheme/>
    </>
  )
}

export default Header;