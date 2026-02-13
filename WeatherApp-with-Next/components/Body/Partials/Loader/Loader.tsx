import { ReactElement } from 'react';
import './Loader.css';

const Loader = (): ReactElement => {
  return (
    <div className="wrapper">
      <span className="loader" />
    </div>
  )
}

export default Loader;