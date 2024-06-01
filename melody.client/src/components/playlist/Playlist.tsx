import { ChangeEvent, createRef, useEffect, useState } from 'react';
import AudioList from '../../common/components/audio-list/AudioList';
import { AudioItem } from '../../common/models/AudioItem';
import './Playlist.scss';
import FavoriteBorderIcon from '@mui/icons-material/FavoriteBorder';
import MoreHorizIcon from '@mui/icons-material/MoreHoriz';
import PlayArrowIcon from '@mui/icons-material/PlayArrow';
import PauseIcon from '@mui/icons-material/Pause';
import { CreatePlaylistRequest } from '../../common/requests/CreatePlaylistRequest';
import api from '../../config/api-config';
import { defaultImageSrc, useGlobalContext } from '../../contexts/GlobalContext';
import { useParams } from 'react-router-dom';
import { CollectionItem } from '../../common/models/CollectionItem';
import { toDurationString } from '../../common/utils/stringUtils';

type PlaylistProps = {
    editMode?: boolean;
}

const Playlist: React.FunctionComponent<PlaylistProps> = ({ editMode }) => {
    const { state, setState } = useGlobalContext() ?? { }
    const { id } = useParams();
    const [request, setRequest] = useState<CreatePlaylistRequest>({ 
        title: '',
        coversheet: null, 
        description: '',
        tagIds: [],
        isPublic: false,
        creatorId: state?.currentUser?.uid ?? ''
    });
    const [audios, setAudios] = useState<AudioItem[]>([]);
    const [collectionItem, setCollectionItem] = useState<CollectionItem>();

    const fileInputRef = createRef<HTMLInputElement>();
    const [imageSrc, setImageSrc] = useState<string>('');

    const handleFileChange = (event: ChangeEvent<HTMLInputElement>) => {
        const file = event.target.files && event.target.files[0];
        if (file) {
            const reader = new FileReader();
            reader.onload = (e) => {
                const result = e.target?.result as string;
                setImageSrc(result);
            };
            reader.readAsDataURL(file);
            setRequest({
                ...request,
                coversheet: file
            } as CreatePlaylistRequest);
        }
    };

    const togglePlay = () => {
        if (state && setState) {
            setState({
                ...state,
                isPlaying: !state.isPlaying
            });
        }
    }

    const handleButtonClick = () => {
        if (fileInputRef.current) {
            fileInputRef.current.click();
        }
    };

    const sendCreationRequest = (
        onSuccess: () => void, 
        onFailure: () => void) => {
        const formData = new FormData();
        const { coversheet, ...data } = request;
    
        formData.append('data', JSON.stringify(data));
    
        if (coversheet) {
          formData.append('file', coversheet, coversheet.name)
        }
    
        fetch(`${api.baseUrl}/playlists`, {
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

    const createPlaylist = (e: any) => {
        e.preventDefault();
        if (request && request.title && request.description) {
            sendCreationRequest(
                () => {
                    alert('Playlist has been created successfully!');
                    location.href = '/';
                },
                () => {
                    alert('The issue found on creating playlist!');
                }
            )
        }
    }

    const fetchAudios = async () => {
        const response = await fetch(`${api.baseUrl}/playlists/${id}/tracks`);
        const json = await response.json();
        setAudios(json.map(function (a: any): AudioItem {
            return {
                id: a.id ?? a.externalId,
                title: a.title,
                audioSrc: a.downloadUrl,
                author: a.author,
                imageSrc: a.coversheetUrl,
                duration: a.durationInMs,
                progress: 0
            };
        }) ?? []);
    }

    const fetchPlaylistData = async () => {        
        const response = await fetch(`${api.baseUrl}/playlists/${id}`);
        const p = await response.json();
        setCollectionItem({
            id: p.id,
            title: p.title,
            coversheetSrc: p.coversheetUrl,
            author: p.author,
            description: p.description
        });
    }

    useEffect(() => {
        if (!editMode) {
            fetchAudios();
            fetchPlaylistData();
        }
    }, [])

    useEffect(() => {
        if (collectionItem?.coversheetSrc) {
            setImageSrc(collectionItem?.coversheetSrc);
        }
    }, [collectionItem?.coversheetSrc])
    
    return (
        <div className='Playlist'>
            <div className='playlist-info'>
                <div className="playlist-img">
                    <img                        
                        onClick={() => {
                                if (editMode) {
                                    handleButtonClick();
                                }
                        }}

                        src={!imageSrc ? defaultImageSrc : imageSrc}
                        alt="Playlist Image"
                        style={{ maxWidth: '300px', maxHeight: '300px' }}
                    />
                    { editMode && <input
                        type="file"
                        ref={fileInputRef}
                        onChange={handleFileChange}
                        style={{ display: 'none' }}
                    />}
                </div>
                <div className="playlist-text">
                    <span>Playlist</span>
                    <h1 className='playlist-title'>
                        { editMode ? 
                        <input 
                            type='text' 
                            placeholder='Enter title'
                            onChange={(e: ChangeEvent<HTMLInputElement>) => {
                                setRequest({
                                    ...request,
                                    title: e.target.value
                                } as CreatePlaylistRequest);
                            }}
                         /> : 
                        collectionItem?.title ?? 'Liked Songs' }
                    </h1>
                    <p className='playlist-desc'>
                        { editMode ? 
                        <input 
                            type='text' 
                            placeholder='Enter description'
                            onChange={(e: ChangeEvent<HTMLInputElement>) => {
                                setRequest({
                                    ...request,
                                    description: e.target.value
                                } as CreatePlaylistRequest);
                            }}
                         /> : 
                         collectionItem?.description ?? 'Music for concentration' }
                    </p>
                    <div className="playlist-extra">
                        <span>Provided by {collectionItem?.author ?? 'Me'}</span>
                        <span>&#9702;</span>
                        <span>{audios.length}, {toDurationString(audios.map(a => a.duration).reduce((prev, cur) => (prev ?? 0) + (cur ?? 0), 0) ?? 0)}</span>
                        <span>&#9702;</span>
                        <span>100 000 likes</span>
                    </div>
                    {editMode && 
                        <div className="playlist-checkbox">
                            <input 
                                type='checkbox' 
                                onChange={(e: ChangeEvent<HTMLInputElement>) => {
                                    setRequest({
                                        ...request,
                                        isPublic: e.target.checked
                                    } as CreatePlaylistRequest);
                                }} 
                            />
                            <label>Make playlist public</label>
                        </div>
                    }
                    {editMode && <button className='create-playlist-btn' type="submit" onClick={createPlaylist}>Create</button> }
                </div>
            </div>
            <div className="playlist-controls">
                <div className="play-btn">
                    { state?.isPlaying ? 
                        <PauseIcon onClick={togglePlay} /> : 
                        <PlayArrowIcon onClick={() => {
                            const setQueue = () => {
                                if (setState) {
                                    setState({
                                        ...state,
                                        isPlaying: true,
                                        searchString: state?.searchString ?? '',
                                        current: audios[0],
                                        queue: audios.slice(0, audios.length)
                                    });
                                }
                            }

                            setQueue();
                        }} />
                    }
                </div>
                <div className="follow-btn">
                    <FavoriteBorderIcon />
                </div>
                <div className="more-btn">
                    <MoreHorizIcon />
                </div>
            </div>
            <div className="playlist-items">
                <AudioList audios={audios.length > 0 ? audios : populateAudios()} />
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