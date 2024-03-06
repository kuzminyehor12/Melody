import { Link, LinkProps } from 'react-router-dom';
import './DefaultLink.scss';

const DefaultLink: React.FunctionComponent<LinkProps> = (props: LinkProps) => {
    return (
        <Link to={props.to} style={{ textDecoration: 'none', color: 'inherit'}}>
            {props.children}
        </Link>
    );
}

export default DefaultLink;