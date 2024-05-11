import './Sidebar.scss';
import MusicNoteIcon from '@mui/icons-material/MusicNote';
import HomeIcon from '@mui/icons-material/Home';
import SearchIcon from '@mui/icons-material/Search';
import LibraryMusicIcon from '@mui/icons-material/LibraryMusic';
import DefaultLink from '../../common/components/default-link/DefaultLink';
import FileUploadIcon from '@mui/icons-material/FileUpload';
import AddCircleOutlineIcon from '@mui/icons-material/AddCircleOutline';
import { useState } from 'react';
import UploadAudioForm from '../upload-audio-form/UploadAudioForm';
import { useGlobalContext } from '../../contexts/GlobalContext';

const Sidebar: React.FunctionComponent = () => {
    const [openUpload, setOpenUpload] = useState(false);
    const { state } = useGlobalContext() ?? { };

    const doActive = (e: React.MouseEvent<HTMLLIElement>) => {
        const links = document.querySelectorAll('li');
        links.forEach(a => a.classList.remove('active'));
        e.currentTarget.classList.add('active');
    }

    const openUploadAudioForm = () => {
        setOpenUpload(true);
    }

    return (
        <div className='Sidebar'>
            <div className="logo">
                <MusicNoteIcon /> <span>Melody</span>
            </div>
            <hr />
            <div className="nav-links">
                <ul>
                    <DefaultLink to='/'>
                        <li onClick={doActive}><HomeIcon /> <span>Home</span></li>
                    </DefaultLink>
                    <DefaultLink to='/search'>
                        <li onClick={doActive}><SearchIcon /> <span>Search</span></li>
                    </DefaultLink>
                    {
                        !state?.currentUser?.isAnonymous &&
                        <DefaultLink to='/my-library'>
                            <li onClick={doActive}><LibraryMusicIcon /> <span>My Library</span></li>
                        </DefaultLink>
                    }
                </ul>
            </div>
            <hr />
            {!state?.currentUser?.isAnonymous && <div className='nav-links'>
                <ul>
                    <DefaultLink to='/playlist'>
                        <li><AddCircleOutlineIcon /> <span>Create Playlist</span></li>
                    </DefaultLink>
                    <li onClick={openUploadAudioForm}><FileUploadIcon /> <span>Upload Audio</span></li>
                    <UploadAudioForm opened={openUpload} setOpened={setOpenUpload}/>
                </ul>
            </div>}
        </div>
    );
}

export default Sidebar;