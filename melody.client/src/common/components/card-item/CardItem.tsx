import { Card } from '../../models/Card';
import DefaultLink from '../default-link/DefaultLink';
import './CardItem.scss';
import PlayArrowIcon from '@mui/icons-material/PlayArrow';

type CardItemProps = {
    card: Card;
}

const CardItem: React.FunctionComponent<CardItemProps> = ({ card }) => {
    return (
        <div className='Card'>
            <DefaultLink to={'/playlist/' + card.id}>
                <div className="card-image">
                    <img src={card.imageUrl} alt='Playlist Image' />
                </div>
                <div className="card-content">
                    <h3>{card.title}</h3>
                    <p>{card.description}</p>
                    <span className="play-icon">
                        <PlayArrowIcon />
                    </span>
                </div>
            </DefaultLink>
        </div>
    );
}

export default CardItem;