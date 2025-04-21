import React, { createContext, ReactNode, useContext, useState } from 'react';

type City = {
  name: string;
};

type CityContextType = {
  city: City;
  setCity: React.Dispatch<React.SetStateAction<City>>;
};

const CityContext = createContext<CityContextType | undefined>(undefined);

type CityContextProviderProps = {
  children: ReactNode;
};

export const CityContextProvider = ({ children }: CityContextProviderProps) => {
  const [city, setCity] = useState<City>({name: ""});

  return (
    <CityContext.Provider value={{ city, setCity }}>
      {children}
    </CityContext.Provider>
  );
};

// Custom hook to use the CityContext
export const useCityContext = () => {
  const context = useContext(CityContext);
  if (!context) {
    throw new Error('useCityContext must be used within a CityContextProvider!');
  }
  return context;
};