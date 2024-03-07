import AudioList from '../../common/components/audio-list/AudioList';
import { AudioItem } from '../../common/models/AudioItem';
import './Playlist.scss';
import FavoriteBorderIcon from '@mui/icons-material/FavoriteBorder';
import FavoriteIcon from '@mui/icons-material/Favorite';
import MoreHorizIcon from '@mui/icons-material/MoreHoriz';
import PlayArrowIcon from '@mui/icons-material/PlayArrow';

const Playlist: React.FunctionComponent = () => {
    return (
        <div className='Playlist'>
            <div className='playlist-info'>
                <div className="playlist-img">
                    <img src="https://misc.scdn.co/liked-songs/liked-songs-300.png" alt="Playlist Image" />
                </div>
                <div className="playlist-text">
                    <span>Playlist</span>
                    <h1 className='playlist-title'>Liked Songs</h1>
                    <p className='playlist-desc'>Music for concentration</p>
                    <div className="playlist-extra">
                        <span>Provided by Melody</span>
                        <span>&#9702;</span>
                        <span>100 songs, 2hr</span>
                        <span>&#9702;</span>
                        <span>600 000 likes</span>
                    </div>
                </div>
            </div>
            <div className="playlist-controls">
                <div className="play-btn">
                    <PlayArrowIcon />
                </div>
                <div className="follow-btn">
                    <FavoriteBorderIcon />
                </div>
                <div className="more-btn">
                    <MoreHorizIcon />
                </div>
            </div>
            <div className="playlist-items">
                <AudioList audios={populateAudios()} />
            </div>
        </div>
    );
}

function populateAudios(): AudioItem[] {
    return [
        {
            id: '1',
            title: 'Scary Monsters',
            author: 'David Bowie',
            imageSrc: '',
            duration: 100,
            progress: 0
        },
        {
            id: '2',
            title: 'Scary Monsters',
            author: 'David Bowie',
            imageSrc: '',
            duration: 100,
            progress: 0
        },
        {
            id: '3',
            title: 'Scary Monsters',
            author: 'David Bowie',
            imageSrc: '',
            duration: 100,
            progress: 0
        },
        {
            id: '4',
            title: 'Scary Monsters',
            author: 'David Bowie',
            imageSrc: '',
            duration: 100,
            progress: 0
        },
        {
            id: '5',
            title: 'Scary Monsters',
            author: 'David Bowie',
            imageSrc: '',
            duration: 100,
            progress: 0
        },
        {
            id: '6',
            title: 'Scary Monsters',
            author: 'David Bowie',
            imageSrc: '',
            duration: 100,
            progress: 0
        },
        {
            id: '7',
            title: 'Scary Monsters',
            author: 'David Bowie',
            imageSrc: '',
            duration: 100,
            progress: 0
        },
        {
            id: '8',
            title: 'Scary Monsters',
            author: 'David Bowie',
            imageSrc: '',
            duration: 100,
            progress: 0
        },
        {
            id: '9',
            title: 'Scary Monsters',
            author: 'David Bowie',
            imageSrc: '',
            duration: 100,
            progress: 0
        },
        {
            id: '10',
            title: 'Scary Monsters',
            author: 'David Bowie',
            imageSrc: '',
            duration: 100,
            progress: 0
        }
    ]
}

export default Playlist;