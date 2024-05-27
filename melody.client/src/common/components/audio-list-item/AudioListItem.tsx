import { useGlobalContext } from '../../../contexts/GlobalContext';
import { AudioItem } from '../../models/AudioItem';
import { toDurationString } from '../../utils/stringUtils';
import './AudioListItem.scss';
import MusicNoteIcon from '@mui/icons-material/MusicNote';
import AddCircleOutlineIcon from '@mui/icons-material/AddCircleOutline';
import DownloadIcon from '@mui/icons-material/Download';
import { useLocation } from 'react-router-dom';
import { useState } from 'react';
import IncludeIntoPlaylistForm from '../../../components/include-into-playlist-form/IncludeIntoPlaylistForm';

type AudioListItemProps = {
    audioItem: AudioItem;
    onClick: () => void;
}

const AudioListItem: React.FunctionComponent<AudioListItemProps> = ({ audioItem, onClick }) => {
    const loc = useLocation();
    const { state } = useGlobalContext() ?? { };
    const [openForm, setOpenForm] = useState(false);

    const handleDownload = (e: any) => {
        e.stopPropagation();
    }

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
                {(!state?.currentUser?.isAnonymous && loc.pathname.includes('search')) && <span onClick={(e) => {
                    e.stopPropagation();
                    setOpenForm(true)
                }}><AddCircleOutlineIcon /></span> }
                {!state?.currentUser?.isAnonymous && <a href={audioItem.audioSrc} download target='_blank'><DownloadIcon /></a>}
            </div>
            <div className="audio-duration">
                <span>{toDurationString(Number.isNaN(audioItem.duration) ? 0 : (audioItem.duration ?? 0))}</span>
            </div>
            <IncludeIntoPlaylistForm track={audioItem} opened={openForm} setOpened={setOpenForm}/>
        </div>
    );
}

export default AudioListItem;