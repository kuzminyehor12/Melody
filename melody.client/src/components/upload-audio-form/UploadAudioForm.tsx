import Button from '@mui/material/Button';
import TextField from '@mui/material/TextField';
import Dialog from '@mui/material/Dialog';
import DialogActions from '@mui/material/DialogActions';
import DialogContent from '@mui/material/DialogContent';
import DialogContentText from '@mui/material/DialogContentText';
import DialogTitle from '@mui/material/DialogTitle';
import { ThemeProvider, createTheme } from '@mui/material/styles';
import { IconButton, MenuItem, Select } from '@mui/material';
import { FileUploadOutlined } from '@mui/icons-material';

const darkTheme = createTheme({
  palette: {
    mode: 'dark'
  },
});

type UploadAudioFormProps = {
  opened: boolean;
  setOpened: (opened: boolean) => void;
}

const UploadAudioForm: React.FunctionComponent<UploadAudioFormProps> = ({ opened, setOpened }) => {
  const handleClose = () => {
    setOpened(false);
  };

  return (
    <ThemeProvider theme={darkTheme}>
        <Dialog
        open={opened}
        onClose={handleClose}
        PaperProps={{
          component: 'form',
          onSubmit: (event: React.FormEvent<HTMLFormElement>) => {
            event.preventDefault();
            const formData = new FormData(event.currentTarget);
            const formJson = Object.fromEntries((formData as any).entries());
            const email = formJson.email;
            console.log(email);
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
          />
          <TextField
            required
            margin="dense"
            id="audio-description"
            name="audio-description"
            label="Description"
            type="text"
            fullWidth
            variant="standard"
          />
          <Select
            id="audio-type"
            value={0}
            label="Type"
            style={{ marginTop: '12px' }}
            // onChange={handleChange}
          >
            <MenuItem value={0}>Single</MenuItem>
            <MenuItem value={1}>Album</MenuItem>
            <MenuItem value={2}>Podcast</MenuItem>
            <MenuItem value={3}>Audiobook</MenuItem>
            <MenuItem value={4}>Audiobook Collection</MenuItem>
          </Select>
          <TextField
            style={{ marginLeft: '225px' }}
            variant="standard"          
            type="text"
            InputProps={{
              endAdornment: (
                <IconButton component="label">
                  <FileUploadOutlined />
                  <input
                    style={{display:"none"}}
                    type="file"
                    hidden
                    // onChange={handleUpload}
                    name="[licenseFile]"
                  />
                </IconButton>
              ),
            }}
          />
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