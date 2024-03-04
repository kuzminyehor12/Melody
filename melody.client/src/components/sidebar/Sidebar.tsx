import './Sidebar.scss';
import MusicNoteIcon from '@mui/icons-material/MusicNote';
import HomeIcon from '@mui/icons-material/Home';
import SearchIcon from '@mui/icons-material/Search';
import LibraryMusicIcon from '@mui/icons-material/LibraryMusic';

const Sidebar: React.FunctionComponent = () => {
    return (
        <div className='Sidebar'>
            <div className="logo">
                <MusicNoteIcon /> <span>Melody</span>
            </div>
            <hr />
            <div className="nav-links">
                <ul>
                    <li className='active'><HomeIcon /> <span>Home</span></li>
                    <li><SearchIcon /> <span>Search</span></li>
                    <li><LibraryMusicIcon /> <span>My Library</span></li>
                </ul>
            </div>
            <hr />
        </div>
    );
}

export default Sidebar;