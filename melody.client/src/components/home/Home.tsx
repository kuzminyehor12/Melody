import LineItem from '../../common/components/line-item/LineItem';
import './Home.scss';

const Home: React.FunctionComponent = () => {
    return (
        <div className='Home'>
            <LineItem title='Uniquely yours' cards={[
                {
                    title: 'Liked Songs',
                    imageUrl: 'https://misc.scdn.co/liked-songs/liked-songs-300.png',
                    description: 'Music to help you concentrate for...'
                }
            ]} />
            <LineItem title='Focus' cards={[
                {
                    title: 'Music for concentration',
                    imageUrl: 'https://misc.scdn.co/liked-songs/liked-songs-300.png',
                    description: ''
                },
                {
                    title: 'Music for concentration',
                    imageUrl: 'https://misc.scdn.co/liked-songs/liked-songs-300.png',
                    description: ''
                },
                {
                    title: 'Music for concentration',
                    imageUrl: 'https://misc.scdn.co/liked-songs/liked-songs-300.png',
                    description: ''
                },
                {
                    title: 'Music for concentration',
                    imageUrl: 'https://misc.scdn.co/liked-songs/liked-songs-300.png',
                    description: ''
                }
            ]} />
        </div>
    );
}

export default Home;