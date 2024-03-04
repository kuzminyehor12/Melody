import './App.scss';
import Home from './components/home/Home';
import Player from './components/player/Player';
import Sidebar from './components/sidebar/Sidebar';

const App: React.FunctionComponent = () => {
    return (
        <div className='wrapper'>
            <div className='App'>
                <Sidebar />
                <div className="scroll-wrapper">
                    <div className='app-content'>
                        <div className='upper-nav'>
                            Dummy text
                        </div>
                        <Home />
                    </div>
                </div>
            </div>
            <Player />
        </div>
    );
}

export default App;