import './Sidebar.scss';
import MusicNoteIcon from '@mui/icons-material/MusicNote';
import HomeIcon from '@mui/icons-material/Home';
import SearchIcon from '@mui/icons-material/Search';
import LibraryMusicIcon from '@mui/icons-material/LibraryMusic';
import DefaultLink from '../../common/components/default-link/DefaultLink';
import FileUploadIcon from '@mui/icons-material/FileUpload';
import AddCircleOutlineIcon from '@mui/icons-material/AddCircleOutline';

const Sidebar: React.FunctionComponent = () => {
    const doActive = (e: React.MouseEvent<HTMLLIElement>) => {
        const links = document.querySelectorAll('li');
        links.forEach(a => a.classList.remove('active'));
        e.currentTarget.classList.add('active');
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
                    <DefaultLink to='/my-library'>
                        <li onClick={doActive}><LibraryMusicIcon /> <span>My Library</span></li>
                    </DefaultLink>
                </ul>
            </div>
            <hr />
            <div className='nav-links'>
                <ul>
                    <li><AddCircleOutlineIcon /> <span>Create Playlist</span></li>
                    <li><FileUploadIcon /> <span>Upload Audio</span></li>
                </ul>
            </div>
        </div>
    );
}

export default Sidebar;