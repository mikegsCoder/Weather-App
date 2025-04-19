import './Header.css';

import Theme from '../../enumerations/theme';

import { useEffect, useState } from 'react';
import { FiMoon, FiSun } from 'react-icons/fi';

const Header = (props: {
  logo: string,
  reactTSUrl: string
}): JSX.Element => {
  const [theme, setTheme] = useState(Theme[0]);

  const toggleTheme = (): void => {
    theme == Theme[0] ? setTheme(Theme[1]) : setTheme(Theme[0]);
  };

  useEffect((): void => {
    document.body.className = theme;
  }, [theme]);

  return (
    <>
      <a
        href={props.reactTSUrl}
        target={"_blank"}
        rel="noreferrer"
        className="text-3xl flex items-center gap-2 absolute top-2 left-10 font-semibold"
      >
        <img src={props.logo} className="w-[120px]" id="logo" alt="logo" />
        Weather App with React.TS
      </a>
      <div className="icon-button toggle-theme">
        <input
          type="checkbox"
          className="checkbox"
          id="checkbox"
          onClick={toggleTheme}
        />
        <label
          htmlFor="checkbox"
          className="label top-2 right-10"
        >
          <FiMoon color="white" />
          <FiSun color="yellow" />
          <div className="ball"></div>
        </label>
      </div>
      <hr className='hr-top' />
    </>
  )
}

export default Header;