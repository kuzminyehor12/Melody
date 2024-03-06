import { Card } from '../../models/Card';
import CardItem from '../card-item/CardItem';
import './LineItem.scss';

type LineItemProps = {
    title: string,
    cards: Card[]
}

const LineItem: React.FunctionComponent<LineItemProps> = ({ title, cards }: LineItemProps) => {
    return (
        <div className='content'>
            <h1>{ title }</h1>
            <div className='card-line'>
                {cards.map((c, idx) => <CardItem card={c} key={idx}/>)}
            </div>
        </div>
    );
}

export default LineItem;