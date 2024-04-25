import { MenuItem, Select, SelectChangeEvent, createTheme } from '@mui/material';
import './FilterPanel.scss';
import React from 'react';
import { SearchType } from '../../common/enums/SearchType';
import { useGlobalContext } from '../../contexts/GlobalContext';
import { FilterOptions } from '../../common/models/FilterOptions';
import { ThemeProvider } from '@emotion/react';

type FilterPanelProps = {
    opened: boolean;
}

const darkTheme = createTheme({
    palette: {
      mode: 'dark'
    },
  });

const FilterPanel: React.FunctionComponent<FilterPanelProps> = ({ opened }) => {
  const { state, setState } = useGlobalContext() ?? { };

  const setFilter = (e: SelectChangeEvent<SearchType>) => {
    if (state?.filter && setState) {
        const newFilter: FilterOptions = {
            ...state?.filter,
            type: e.target.value as SearchType
        };

        setState({
            ...state,
            filter: newFilter
        })
    }
  }

  return (
    <>
    { opened &&  
        <div className='filter-panel'>
            <ThemeProvider theme={darkTheme}>
                <Select
                    id="search-type"
                    value={state?.filter?.type}
                    label="Type"
                    style={{ width: '100%' }}
                    onChange={setFilter}
                >
                    <MenuItem value={SearchType.Track}>Track</MenuItem>
                    <MenuItem value={SearchType.Playlist}>Playlist</MenuItem>
                    <MenuItem value={SearchType.Album}>Album</MenuItem>
                    <MenuItem value={SearchType.Podcast}>Podcast</MenuItem>
                    <MenuItem value={SearchType.Audiobook}>Audiobook</MenuItem>
                    <MenuItem value={SearchType.AudiobookCollection}>Audiobook Collection</MenuItem>
                </Select>
            </ThemeProvider>
        </div>
    }
    </>
  );
};

export default FilterPanel;