import LineItem from '../../common/components/line-item/LineItem';
import './Home.scss';

const Home: React.FunctionComponent = () => {
    return (
        <div className='Home'>
            <LineItem title='Uniquely yours' cards={[
                {
                    id: '1',
                    title: 'Liked Songs',
                    imageUrl: 'https://misc.scdn.co/liked-songs/liked-songs-300.png',
                    description: 'Music to help you concentrate for...'
                }
            ]} />
            <LineItem title='Focus' cards={[
                {
                    id: '2',
                    title: 'Music for concentration',
                    imageUrl: 'https://misc.scdn.co/liked-songs/liked-songs-300.png',
                    description: ''
                },
                {
                    id: '3',
                    title: 'Music for concentration',
                    imageUrl: 'https://misc.scdn.co/liked-songs/liked-songs-300.png',
                    description: ''
                },
                {
                    id: '4',
                    title: 'Music for concentration',
                    imageUrl: 'https://misc.scdn.co/liked-songs/liked-songs-300.png',
                    description: ''
                },
                {
                    id: '5',
                    title: 'Music for concentration',
                    imageUrl: 'https://misc.scdn.co/liked-songs/liked-songs-300.png',
                    description: ''
                }
            ]} />
        </div>
    );
}

export default Home;