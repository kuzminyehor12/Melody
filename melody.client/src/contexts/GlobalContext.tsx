import React, { PropsWithChildren, createContext, useContext, useState } from 'react';
import { AudioItem } from '../common/models/AudioItem';
import { FilterOptions } from '../common/models/FilterOptions';
import { SearchType } from '../common/enums/SearchType';
import { Identity } from '../common/models/Identity';

interface GlobalState {
    isPlaying?: boolean;
    current?: AudioItem;
    queue?: AudioItem[];
    searchString?: string;
    filter?: FilterOptions;
    currentUser?: Identity;
}

interface GlobalContextType {
    state: GlobalState;
    setState: React.Dispatch<React.SetStateAction<GlobalState>>;
}

const GlobalContext = createContext<GlobalContextType | undefined>(undefined);

export const useGlobalContext = () => useContext(GlobalContext);

export const defaultImageSrc = 'https://community.spotify.com/t5/image/serverpage/image-id/25294i2836BD1C1A31BDF2/image-size/original?v=mpbl-1&px=-1';

export const GlobalProvider: React.FunctionComponent<PropsWithChildren> = ({ children }) => {
  const [state, setState] = useState<GlobalState>({ 
    isPlaying: false, 
    current: {
        id: '-1',
        title: 'Another One Bites The Dust',
        author: 'Queen',
        imageSrc: defaultImageSrc
    },
    searchString: '',
    filter: {
      type: SearchType.Track,
      tagIds: [],
      genreIds: []
    },
    currentUser: {
      email: '',
      uid: '',
      displayName: '',
      isAnonymous: true
    }
  });

  return (
    <GlobalContext.Provider value={{ state, setState }}>
      {children}
    </GlobalContext.Provider>
  );
};