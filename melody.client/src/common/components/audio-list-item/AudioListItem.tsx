import { useGlobalContext } from '../../../contexts/GlobalContext';
import { AudioItem } from '../../models/AudioItem';
import { toDurationString } from '../../utils/stringUtils';
import './AudioListItem.scss';
import MusicNoteIcon from '@mui/icons-material/MusicNote';
import AddCircleOutlineIcon from '@mui/icons-material/AddCircleOutline';
import DownloadIcon from '@mui/icons-material/Download';
import { useLocation } from 'react-router-dom';

type AudioListItemProps = {
    audioItem: AudioItem;
    onClick: () => void;
}

const AudioListItem: React.FunctionComponent<AudioListItemProps> = ({ audioItem, onClick }) => {
    const loc = useLocation();
    const { state } = useGlobalContext() ?? { };

    const isCurrentItem = state?.current?.id === audioItem.id;

    return (
        <div className={`audio-list-item ${isCurrentItem ? 'active' : ''}`} onClick={onClick}>
            <div className="audio-info">
                <div className="audio-icon">
                    <MusicNoteIcon />
                </div>
                <div className="audio-text">
                    <p className='audio-title'>{audioItem.title}</p>
                    <p className='audio-author'>{audioItem.author}</p>
                </div>
            </div>
            <div className="audio-controls">
                { loc.pathname.includes('search') && <AddCircleOutlineIcon /> }
                <DownloadIcon />
            </div>
            <div className="audio-duration">
                <span>{toDurationString(Number.isNaN(audioItem.duration) ? 0 : (audioItem.duration ?? 0))}</span>
            </div>
        </div>
    );
}

export default AudioListItem;