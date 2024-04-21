import Button from '@mui/material/Button';
import TextField from '@mui/material/TextField';
import Dialog from '@mui/material/Dialog';
import DialogActions from '@mui/material/DialogActions';
import DialogContent from '@mui/material/DialogContent';
import DialogContentText from '@mui/material/DialogContentText';
import DialogTitle from '@mui/material/DialogTitle';
import { ThemeProvider, createTheme } from '@mui/material/styles';
import { Checkbox, IconButton, MenuItem, Select, SelectChangeEvent } from '@mui/material';
import { FileUploadOutlined } from '@mui/icons-material';
import { AudioType } from '../../common/enums/AudioType';
import { UploadAudioRequest } from '../../common/requests/UploadAudioRequest';
import { ChangeEvent, useEffect, useState } from 'react';
import ClearIcon from '@mui/icons-material/Clear';
import MultiSelect, { Option } from '../../common/components/multi-select/MultiSelect';
import api from '../../config/api-config';

const darkTheme = createTheme({
  palette: {
    mode: 'dark'
  },
});

type UploadAudioFormProps = DialogProps;

const UploadAudioForm: React.FunctionComponent<UploadAudioFormProps> = ({ opened, setOpened }) => {
  const [selectedGenres, setSelectedGenres] = useState<Option[]>([]);
  const [genres, setGenres] = useState<Option[]>([]);

  const fetchGenres = () => {
    fetch(`${api.baseUrl}/list/genres`)
    .then(response => response.json())
    .then(data => setGenres(data?.map(function (g: any): Option {
      return {
          text: g.displayName,
          value: g.id
      };
    }) ?? []))
    .catch(err => console.log(err));
  };

  const sendUploadRequest = (
    onSuccess: () => void, 
    onFailure: () => void) => {
    const formData = new FormData();
    const { file, ...data } = request;

    formData.append('data', JSON.stringify(data));

    if (file) {
      formData.append('file', file, file.name)
    }

    fetch(`${api.baseUrl}/upload`, {
      method: 'POST',
      body: formData
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

  const handleMultiSelectChange = (e: React.ChangeEvent<{}>, selectedOptions: Option[]) => {
    const seen: Map<string, boolean> = new Map<string, boolean>();
    let uniqueSelectedOptions = selectedOptions.filter(o => {
        if (!seen.get(o.text)) {
            seen.set(o.text, true);
            return true;
        }
        return false;
    });

    setSelectedGenres(uniqueSelectedOptions);
    setRequest({
      ...request,
      genreIds: uniqueSelectedOptions.map(g => g.value)
    });
  };

  const [checked, setChecked] = useState<boolean>(false);
  const [request, setRequest] = useState<UploadAudioRequest>({ 
      title: '', 
      author: '', 
      file: null, 
      description: '', 
      type: 0, 
      genreIds: [], 
      collectionId: null 
  });

  const handleClose = () => {
    setRequest({ 
      title: '', 
      author: '', 
      file: null, 
      description: '', 
      type: 0, 
      genreIds: [], 
      collectionId: null 
    });
    setGenres([]);
    setSelectedGenres([]);
    setOpened(false);
  };

  const hasDescription = request?.type !== AudioType.Track;
  const hasGenres = request?.type === AudioType.Track || request?.type === AudioType.Album;
  const isCollection = request?.type === AudioType.Album || request?.type === AudioType.AudiobookCollection;
  const isIncludable = request?.type === AudioType.Track || request?.type === AudioType.Audiobook;

  const handleUpload = (e: ChangeEvent<HTMLInputElement>): void => {
    e.preventDefault();

    const doAlert = () => {
      alert('Please select an audio file.');
      e.target.files = null;
    }

    const file: File | null = !e.target.files ? null : e.target.files[0];
    if (file && file.type.startsWith('audio/')) {
      setRequest({
        ...request,
        file
      } as UploadAudioRequest);
    } else {
      doAlert();
      return;
    }
  };

  return (
    <ThemeProvider theme={darkTheme}>
        <Dialog
          open={opened}
          onClose={handleClose}
          PaperProps={{
            component: 'form',
            onSubmit: (e: React.FormEvent<HTMLFormElement>) => {
              e.preventDefault();
              sendUploadRequest(
              () => {
                alert('Audio has been uploaded successfully!');
              },
              () => {
                alert('The issue found on uploading audio!');
              })
              handleClose();
            },
          }}
        >
        <DialogTitle>Upload Audio</DialogTitle>
        <DialogContent>
          <DialogContentText style={{ color: 'white' }}>
            To upload audio please enter audio title, author name, select audio type and upload a file.
          </DialogContentText>
          <TextField
            required
            margin="dense"
            id="audio-title"
            name="audio-title"
            label="Title"
            type="text"
            fullWidth
            variant="standard"
            onChange={(e: ChangeEvent<HTMLInputElement>) => {
                e.preventDefault();
                if (e.target.value) {
                  setRequest({
                    ...request,
                    title: e.target.value
                  } as UploadAudioRequest);
                }
            }}
          />
          <TextField
            required
            margin="dense"
            id="audio-author"
            name="audio-author"
            label="Authors"
            type="text"
            fullWidth
            variant="standard"
            onChange={(e: ChangeEvent<HTMLInputElement>) => {
              e.preventDefault();
              if (e.target.value) {
                setRequest({
                  ...request,
                  author: e.target.value
                } as UploadAudioRequest);
              }
            }}
          />
          {hasDescription && <TextField
            margin="dense"
            id="audio-description"
            name="audio-description"
            label="Description"
            type="text"
            fullWidth
            variant="standard"
            onChange={(e: ChangeEvent<HTMLInputElement>) => {
              e.preventDefault();
              if (e.target.value) {
                setRequest({
                  ...request,
                  description: e.target.value
                } as UploadAudioRequest);
              }
            }}
          />}
          <Select
            id="audio-type"
            value={request.type}
            label="Type"
            style={{ marginTop: '12px' }}
            onChange={(e: SelectChangeEvent<AudioType>) => {
              setRequest({
                ...request,
                type: e.target.value
              } as UploadAudioRequest);
            }}
          >
            <MenuItem value={AudioType.Track}>Track</MenuItem>
            <MenuItem value={AudioType.Album}>Album</MenuItem>
            <MenuItem value={AudioType.Podcast}>Podcast</MenuItem>
            <MenuItem value={AudioType.Audiobook}>Audiobook</MenuItem>
            <MenuItem value={AudioType.AudiobookCollection}>Audiobook Collection</MenuItem>
          </Select>
        {hasGenres && 
          <MultiSelect
              options={genres}
              value={selectedGenres}
              onClick={fetchGenres}
              onChange={handleMultiSelectChange}
              label='Select Multiple Genres'
          />
        }
        {isIncludable && 
          <>
            <div style={{ width: '550px', marginTop: '10px', padding: 0 }}>
              <Checkbox checked={checked} onChange={() => setChecked(!checked)} />
              <label>{request?.type === AudioType.Track ? 'Include into album' : 'Include into audio book collection'}</label>
            </div>
            {checked && <Select
              id="audio-collection"
              value={request?.collectionId ?? 'undefined'}
              label={request?.type === AudioType.Track ? 'Select an album' : 'Select an audio book collection'}
              style={{ marginTop: '12px' }}
              onChange={(e: SelectChangeEvent<string>) => {
                setRequest({
                  ...request,
                  collectionId: e.target.value
                } as UploadAudioRequest);
              }}
            >
              <MenuItem value={'undefined'}>{request?.type === AudioType.Track ? 'Select an album' : 'Select an audio book collection'}</MenuItem>
              <MenuItem value={'1'}>Album 1</MenuItem>
              <MenuItem value={'2'}>Album 2</MenuItem>
              <MenuItem value={'3'}>Album 3</MenuItem>
              <MenuItem value={'4'}>Album 4</MenuItem>
              <MenuItem value={'5'}>Album 5</MenuItem>
            </Select>
            }
          </> 
        }
        {!isCollection &&
            <TextField
              style={{ width: '550px' }}
              variant="standard"          
              type="text"
              label={request?.file?.name }
              InputProps={{
                endAdornment: (
                  <>
                    <IconButton component="label">
                      <FileUploadOutlined />
                      <input
                        style={{ display: "none" }}
                        type="file"
                        hidden
                        accept="audio/*"
                        onChange={handleUpload}
                        name="[licenseFile]"
                      />
                    </IconButton>
                    <IconButton 
                      component="label" 
                      onClick={() => setRequest({
                        ...request,
                        file: null
                      })}>
                      <ClearIcon />
                    </IconButton>
                  </>
                ),
              }}
            />
        } 
        </DialogContent>
        <DialogActions>
          <Button onClick={handleClose}>Cancel</Button>
          <Button type="submit">Upload</Button>
        </DialogActions>
      </Dialog>
    </ThemeProvider>
  );
}

export default UploadAudioForm;