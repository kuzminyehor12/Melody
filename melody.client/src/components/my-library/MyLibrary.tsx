import { useEffect, useState } from 'react';
import LineItem from '../../common/components/line-item/LineItem';
import { Card } from '../../common/models/Card';
import './MyLibrary.scss';
import api from '../../config/api-config';
import { useGlobalContext } from '../../contexts/GlobalContext';

const MyLibrary: React.FunctionComponent = () => {
    const { state } = useGlobalContext() ?? { }
    const [followedPlaylists, setFollowedPlaylists] = useState<Card[]>([]);
    const [createdPlaylsts, setCreatedPlaylists] = useState<Card[]>([]);

    useEffect(() => {
        const fetchFollowedPlaylists = async () => {
            const response = await fetch(`${api.baseUrl}/playlists/followed/${state?.currentUser?.uid}`);
            const json = await response.json();
            setFollowedPlaylists(json.map(function (p: any): Card {
                return {
                    id: p.id,
                    title: p.title + ' by ' + (p.author ?? 'Unknown'),
                    description: p.description,
                    imageUrl: p.coversheetUrl
                };
            }) ?? []);
        }
    
        const fetchCreatedPlaylists = async () => {
            const response = await fetch(`${api.baseUrl}/playlists/created/${state?.currentUser?.uid}`);
            const json = await response.json();
            setCreatedPlaylists(json.map(function (p: any): Card {
                return {
                    id: p.id,
                    title: p.title,
                    description: p.description,
                    imageUrl: p.coversheetUrl
                };
            }) ?? []);
        }

        fetchFollowedPlaylists();
        fetchCreatedPlaylists();
    }, [])

    return (
        <div className='MyLibrary'>
            {(followedPlaylists.length > 0) && <LineItem title='Followed Playlists' cards={followedPlaylists} />} 
            {createdPlaylsts && <LineItem title='Created Playlists' cards={createdPlaylsts} />}
        </div>
    );
}

export default MyLibrary;