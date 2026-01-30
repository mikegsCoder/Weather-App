'use client'
import { ReactElement, useEffect, useState } from 'react';
import Theme from '@/enumerations/theme';

const ToggleTheme = (): ReactElement => {
  const [theme, setTheme] = useState(Theme[0]);

  const toggleTheme = (): void => {
    theme == Theme[0] ? setTheme(Theme[1]) : setTheme(Theme[0]);
  };

  useEffect((): void => {
    document.body.className = theme;
  }, [theme]);

  return (
    <>
      <input
        type="checkbox"
        className="checkbox"
        id="checkbox"
        onClick={toggleTheme}
      />
    </>
  )
}

export default ToggleTheme;