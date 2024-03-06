import { useGlobalContext } from '../../../contexts/GlobalContext';
import { AudioItem } from '../../models/AudioItem';
import AudioListItem from '../audio-list-item/AudioListItem';
import './AudioList.scss';

type AudioListProps = {
    audios: AudioItem[]
}

const AudioList: React.FunctionComponent<AudioListProps> = ({ audios }) => {
    const { state, setState } = useGlobalContext() ?? { };

    const setQueue = (id: string) => {
        if (setState) {
            const currentIdx = audios.findIndex(a => a.id == id);
            setState({
                ...state,
                isPlaying: true,
                searchString: state?.searchString ?? '',
                current: audios[currentIdx],
                queue: audios.slice(currentIdx, audios.length)
            });
        }
    }

    return (
        <div className='audio-list'>
            {audios.map(a => <AudioListItem audioItem={a} key={a.id} onClick={() => setQueue(a.id)}/>)}
        </div>
    );
}

export default AudioList;