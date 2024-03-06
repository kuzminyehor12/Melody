import { useEffect, useRef } from 'react';
import { useGlobalContext } from '../../contexts/GlobalContext';
import SkipNextIcon from '@mui/icons-material/SkipNext';
import SkipPreviousIcon from '@mui/icons-material/SkipPrevious';
import PlayArrowIcon from '@mui/icons-material/PlayArrow';
import PauseIcon from '@mui/icons-material/Pause';
import './Player.scss';
import { AudioItem } from '../../common/models/AudioItem';
import { toDurationString } from '../../common/utils/stringUtils';

const Player: React.FunctionComponent = () => {
    const { state, setState } = useGlobalContext() ?? { };
    const audioRef = useRef<HTMLAudioElement>(null);
    const progressClickRef = useRef<HTMLDivElement>(null);

    useEffect(() => {
        if (state && setState && audioRef.current) {
            if (state.isPlaying) {
                audioRef.current.play();
            } else {
                audioRef.current.pause();
            }
        }
    }, [state?.isPlaying, state?.current])


    const togglePlay = () => {
        if (state && setState) {
            setState({
                ...state,
                isPlaying: !state.isPlaying
            });
        }
    }

    const onPlaying = () => {
        if (state && setState && audioRef.current) {
            const duration = audioRef.current.duration;
            const ct = audioRef.current.currentTime;

            setState({
                ...state,
                current: {
                    ...state.current,
                    duration,
                    progress: ct,
                } as (AudioItem | undefined)
            });
        }
    }

    const checkWidth = (e: any) => {
        if (state && setState && progressClickRef.current && audioRef.current) {
            let width = progressClickRef.current.clientWidth;
            const offset = e.nativeEvent.offsetX;
            const progress = offset / width * 100;
            audioRef.current.currentTime = progress / 100 * audioRef.current.duration;
            console.log(audioRef.current.currentTime);
            setState({
                ...state,
                current: {
                    ...state.current,
                    progress: audioRef.current.currentTime
                } as (AudioItem | undefined)
            });
        }
    }

    const skipBack = () => {
        if (state && setState && audioRef.current && state.queue) {
            const index = state.queue.findIndex(x => x.id == state.current?.id);

            if (index == 0) {
                setState({
                    ...state,
                    current: state.queue[state.queue?.length - 1]
                });
            } else {
                setState({
                    ...state,
                    current: state.queue[index - 1]
                });
            }
    
            audioRef.current.currentTime = 0;
        }
    }

    const skipNext = () => {
        if (state && setState && audioRef.current && state.queue) {
            const index = state.queue?.findIndex(x => x.id == state.current?.id);

            if (index == (state.queue.length - 1)) {
                setState({
                    ...state,
                    current: state.queue[0]
                });
            } else {
                setState({
                    ...state,
                    current: state.queue[index + 1]
                });
            }
    
            audioRef.current.currentTime = 0;
        }
    }

    return (
        state?.current && <div className='Player'>
            <audio 
                src='https://cdns-preview-7.dzcdn.net/stream/c-7347e9b2b7eb3157b9fd696d01dcb0b5-7.mp3' 
                hidden 
                ref={audioRef}
                onTimeUpdate={onPlaying}
            />
            <div className="player-info">
                <div className="item-img">
                    <img src="https://misc.scdn.co/liked-songs/liked-songs-300.png" alt="Audio Image" />
                </div>
                <div className="item-text">
                    <p className='item-title'>{state.current.title}</p>
                    <p className='item-author'>{state.current.author}</p>
                </div>
            </div>
            <div className="player-controls">
                <div className="control-elements">
                    <SkipPreviousIcon className='skip-prev-btn' onClick={skipBack}/>
                    <div className="play-btn">
                        { state.isPlaying ? <PauseIcon onClick={togglePlay} /> : <PlayArrowIcon onClick={togglePlay} />}
                    </div>
                    <SkipNextIcon className='skip-next-btn' onClick={skipNext}/>
                </div>
                <div className="player-nav-wrapper">
                    <span>{toDurationString(state.current.progress ?? 0)}</span>
                    <div className="player-nav" ref={progressClickRef} onClick={checkWidth}>
                        <div className="nav-wrapper">
                            <div className="seek-bar" style={{ width: `${(state.current.progress ?? 0) / (state.current.duration ?? 0) * 100 + '%'}`}}/>
                        </div>
                    </div>
                    <span>{toDurationString(state.current.duration ?? 0)}</span>
                </div>
            </div>
        </div>
    );
}

export default Player;