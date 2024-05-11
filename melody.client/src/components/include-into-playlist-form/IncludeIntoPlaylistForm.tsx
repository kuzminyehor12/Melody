import { Button, Dialog, DialogActions, DialogContent, DialogContentText, DialogTitle, ThemeProvider, createTheme } from '@mui/material';
import './IncludeIntoPlaylistForm.scss';
import { AudioItem } from '../../common/models/AudioItem';
import MultiSelect, { Option } from '../../common/components/multi-select/MultiSelect';
import { useState } from 'react';
import api from '../../config/api-config';
import { useGlobalContext } from '../../contexts/GlobalContext';
import { IncludeIntoPlaylistRequest } from '../../common/requests/IncludeIntoPlaylistRequest';

const darkTheme = createTheme({
    palette: {
      mode: 'dark'
    },
});

type IncludeIntoPlaylistFormProps = {
    track: AudioItem;
} & DialogProps;

const IncludeIntoPlaylistForm: React.FunctionComponent<IncludeIntoPlaylistFormProps> = ({ track, opened, setOpened }) => {
    const { state } = useGlobalContext() ?? { };
    const [selectedPlaylists, setSelectedPlaylists] = useState<Option[]>([]);
    const [createdPlaylsts, setCreatedPlaylists] = useState<Option[]>([]);
    const [request, setRequest] = useState<IncludeIntoPlaylistRequest>();

    const handleClose = (e: any) => {
        e.stopPropagation();
        setRequest({
            trackId: '',
            playlistIds: []
        });
        setOpened(false);
    };

    const fetchCreatedPlaylists = async (e: any) => {
        e.stopPropagation();
        const response = await fetch(`${api.baseUrl}/playlists/created/${state?.currentUser?.uid}`);
        const json = await response.json();
        setCreatedPlaylists(json.filter((p: any) => !p.playlistedTrackIds?.includes(track.id)).map(function (p: any) {
            return {
                value: p.id,
                text: p.title
            };
        }) ?? []);
    }

    const handleMultiSelectChange = (e: React.ChangeEvent<{}>, selectedOptions: Option[]) => {
        e.stopPropagation();
        const seen: Map<string, boolean> = new Map<string, boolean>();
        let uniqueSelectedOptions = selectedOptions.filter(o => {
            if (!seen.get(o.text)) {
                seen.set(o.text, true);
                return true;
            }
            return false;
        });
    
        setSelectedPlaylists(uniqueSelectedOptions);
        setRequest({
            ...request,
            trackId: track.id,
            playlistIds: uniqueSelectedOptions.map(o => o.value)
        });
    };

    const sendIncludeTrackRequest = (
        onSuccess: () => void, 
        onFailure: () => void) => {
        fetch(`${api.baseUrl}/track/include`, {
          method: 'POST',
          body: JSON.stringify(request),
          headers: {
            "Content-Type": 'application/json'
          }
        })
        .then(response => {
          if (response.ok) {
            onSuccess();
          } else {
            onFailure();
          }
        })
        .catch(err => console.log(err))
    }

    const handleSubmit = (e: any) => {
        e.stopPropagation();
        sendIncludeTrackRequest(
            () => {
                alert("Track has been included into playlist successfully!");
            },
            () => {
                alert('The issue was found on including track into playlist!');
            }
        );
    }

    return (
      <ThemeProvider theme={darkTheme}>
          <Dialog
            open={opened}
            onClose={handleClose}
            PaperProps={{
              component: 'form',
              onSubmit: (e: React.FormEvent<HTMLFormElement>) => {
                e.preventDefault();
                e.stopPropagation();
                handleSubmit(e);
                handleClose(e);
              },
            }}
          >
          <DialogTitle>Include Track Into Playlist</DialogTitle>
          <DialogContent>
            <DialogContentText style={{ color: 'white' }}>
              Choose a playlist from the list.
            </DialogContentText>
            <DialogContentText style={{ color: 'white' }}>
              Track to add: {track.title + ' by ' + track.author}
            </DialogContentText>
            <MultiSelect
              options={createdPlaylsts}
              value={selectedPlaylists}
              onClick={fetchCreatedPlaylists}
              onChange={handleMultiSelectChange}
              label='Select Multiple Playlists'
            />
          </DialogContent>
          <DialogActions>
            <Button onClick={handleClose}>Cancel</Button>
            <Button type="submit">Include</Button>
          </DialogActions>
        </Dialog>
      </ThemeProvider>
    );
  }
  
  export default IncludeIntoPlaylistForm;