import './Playlist.scss';

const Playlist: React.FunctionComponent = () => {
    return (
        <div className='Playlist'>
            <div className='playlist-info'>
                <div className="playlist-img">
                    <img src="" alt="" />
                </div>
                <div className="playlist-text">
                    <span>Playlist</span>
                    <h1>Liked Songs</h1>
                    <p>Music for concentration</p>
                    <div className="playlist-extra">
                        <span>Provided by Melody</span>
                        <span>100 songs, 2hr</span>
                        <span>600 000 likes</span>
                    </div>
                </div>
            </div>
            <div className="playlist-controls">
                
            </div>
            <div className="playlist-items">

            </div>
        </div>
    );
}

export default Playlist;