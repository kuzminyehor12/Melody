import { useEffect, useState } from 'react';
import { useGlobalContext } from '../../contexts/GlobalContext';
import './Search.scss';
import { AudioItem } from '../../common/models/AudioItem';
import AudioList from '../../common/components/audio-list/AudioList';
import api from '../../config/api-config';
import { CollectionItem } from '../../common/models/CollectionItem';
import { SearchType } from '../../common/enums/SearchType';
import LineItem from '../../common/components/line-item/LineItem';
import { Card } from '../../common/models/Card';

const Search: React.FunctionComponent = () => {
    const { state } = useGlobalContext() ?? { };
    const [audios, setAudios] = useState<AudioItem[]>([]);
    const [collections, setCollections] = useState<CollectionItem[]>([])

    const isAudio = 
        state?.filter?.type === SearchType.Track || 
        state?.filter?.type === SearchType.Podcast || 
        state?.filter?.type === SearchType.Audiobook;

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

        const fetchCollections = async () => {
            if (state?.searchString) {
                const response = await fetch(`${api.baseUrl}/search/collection?query=${state?.searchString}&collectionType=${state.filter?.type}`);
                const json = await response.json();
                setCollections(json.map(function (c: any): CollectionItem {
                    return {
                        id: c.id,
                        title: c.title,
                        coversheetSrc: c.coversheet,
                        author: c.author,
                        description: c.description
                    };
                }) ?? []);
            }
        }

        if (isAudio) {
            fetchAudios();
        } else {
            fetchCollections();
        }

        
    }, [state?.searchString, state?.filter])

    return (
        <div className='Search'>
            {isAudio && <AudioList audios={audios} /> }
            { !isAudio && 
                <LineItem 
                    title={'Search Results'} 
                    cards={collections.map(c => {
                        return {
                            id: c.id,
                            title: c.title + ' by ' + c.author,
                            description: c.description,
                            imageUrl: c.coversheetSrc
                        } as Card;
                    })} 
                />
            }
        </div>
    );
}

export default Search;