import React, { PropsWithChildren, createContext, useContext, useState } from 'react';
import { AudioItem } from '../common/models/AudioItem';

interface GlobalState {
    isPlaying: boolean;
    current?: AudioItem;
    queue?: AudioItem[];
    searchString: string;
}

interface GlobalContextType {
    state: GlobalState;
    setState: React.Dispatch<React.SetStateAction<GlobalState>>;
}

const GlobalContext = createContext<GlobalContextType | undefined>(undefined);

export const useGlobalContext = () => useContext(GlobalContext);

export const GlobalProvider: React.FunctionComponent<PropsWithChildren> = ({ children }) => {
  const [state, setState] = useState<GlobalState>({ 
    isPlaying: false, 
    current: {
        id: '-1',
        title: 'Another One Bites The Dust',
        author: 'Queen',
        imageSrc: 'https://misc.scdn.co/liked-songs/liked-songs-300.png'
    },
    searchString: ''
  });

  return (
    <GlobalContext.Provider value={{ state, setState }}>
      {children}
    </GlobalContext.Provider>
  );
};