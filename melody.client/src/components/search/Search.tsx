import { useEffect, useState } from 'react';
import { useGlobalContext } from '../../contexts/GlobalContext';
import './Search.scss';
import { AudioItem } from '../../common/models/AudioItem';
import AudioList from '../../common/components/audio-list/AudioList';
import api from '../../config/api-config';

const Search: React.FunctionComponent = () => {
    const { state } = useGlobalContext() ?? { };
    const [audios, setAudios] = useState<AudioItem[]>([]);

    useEffect(() => {
        const MAX_AUDIOS_LENGTH = 25;
        const fetchAudios = async () => {
            if (state?.searchString) {
                const response = await fetch(`${api.baseUrl}/search/db?query=` + state?.searchString);
                const json = await response.json();
                setAudios(json.map(function (a: any): AudioItem {
                    return {
                        id: a.id,
                        title: a.title,
                        audioSrc: a.downloadUrl,
                        author: a.author,
                        imageSrc: a.coversheet,
                        duration: a.durationInMs,
                        progress: 0
                    };
                }) ?? []);
            }
            
            if (!audios || audios.length < MAX_AUDIOS_LENGTH) {
                const response = await fetch(`${api.baseUrl}/search/api?query=` + state?.searchString);
                const json = await response.json();
                setAudios([...audios, ...json.data?.slice(0, MAX_AUDIOS_LENGTH - audios.length).map(function (a: any): AudioItem {
                    return {
                        id: a.id,
                        title: a.title,
                        audioSrc: a.preview,
                        author: a.artist.name,
                        imageSrc: a.album.cover_small,
                        duration: a.duration,
                        progress: 0
                    };
                }) ?? []]);
            }
        }

        fetchAudios();
    }, [state?.searchString])

    return (
        <div className='Search'>
            <AudioList audios={audios} />
        </div>
    );
}

export default Search;