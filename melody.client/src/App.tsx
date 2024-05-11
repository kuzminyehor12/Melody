import { Route, Routes, useLocation } from 'react-router-dom';
import './App.scss';
import Home from './components/home/Home';
import Player from './components/player/Player';
import Sidebar from './components/sidebar/Sidebar';
import Search from './components/search/Search';
import MyLibrary from './components/my-library/MyLibrary';
import ChevronLeftIcon from '@mui/icons-material/ChevronLeft';
import ChevronRightIcon from '@mui/icons-material/ChevronRight';
import SearchIcon from '@mui/icons-material/Search';
import { useGlobalContext } from './contexts/GlobalContext';
import { ChangeEvent, useState } from 'react';
import Playlist from './components/playlist/Playlist';
import TuneIcon from '@mui/icons-material/Tune';
import FilterPanel from './components/filter-panel/FilterPanel';
import { UserCredential, signInWithPopup } from 'firebase/auth';
import { auth, provider } from './config/firebase.config';
import api from './config/api-config';

const App: React.FunctionComponent = () => {
    const loc = useLocation();
    const [filterOpen, setFilterOpen] = useState<boolean>(false);
    const { state, setState } = useGlobalContext() ?? { };

    const setSearchItem = (e: ChangeEvent<HTMLInputElement>) => {
        if (setState) {
            setState({
                ...state,
                isPlaying: state?.isPlaying ?? false,
                searchString: e.target.value
            });
        }
    }

    const toggleFilter = () => {
        setFilterOpen(!filterOpen);
    }

    const sendRegisterRequest = (
        creds: UserCredential,
        onSuccess: () => void, 
        onFailure: () => void) => {
        const request = {
            uid: creds.user.uid,
            email: creds.user.email,
            displayName: creds.user.displayName
        }

        fetch(`${api.baseUrl}/auth`, {
          method: 'POST',
          body: JSON.stringify(request),
          headers: {
            "Content-Type": 'application/json'
          }
        })
        .then(response => {
          if (response.ok) {
            onSuccess();
          } else {
            onFailure();
          }
        })
        .catch(err => console.log(err))
    }

    const tryLogin = () => {
        signInWithPopup(auth, provider)
        .then(data => {
            if (setState) {
                setState({
                    ...state,
                    currentUser: {
                        displayName: data.user.displayName ?? '',
                        email: data.user.email ?? '',
                        uid: data.user.uid ?? '',
                        isAnonymous: false
                    }
                });
                
                sendRegisterRequest(
                    data,
                    () => {
                        alert('You have been logged in successfully!');
                    },
                    () => {
                        alert('The issue found on logging you in!');
                    }
                );
            }
        })
        .catch(err => console.error(err));
    }

    const tryLogout = () => {
        if (setState) {
            setState({
                ...state,
                currentUser: {
                    displayName: '',
                    email: '',
                    uid: '',
                    isAnonymous: true
                }
            });
            location.href = '/';
        }
    }

    return (
        <div className='wrapper'>
            <div className='App'>
                <Sidebar />
                <div className="scroll-wrapper">
                    <div className='app-content'>
                        <div className='upper-nav'>
                            <div className="chevron-nav">
                                <div className="chevron">
                                    <ChevronLeftIcon />
                                </div>
                                <div className="chevron">
                                    <ChevronRightIcon />
                                </div>
                            </div>
                            <div className="searchbar">
                                <div className="search-icon">
                                    <SearchIcon />
                                </div>
                                <input 
                                    type="text" 
                                    className="search-text" 
                                    placeholder={!loc.pathname.includes('search') ? 'Go to search' : 'What do you want to play?'}
                                    disabled={!loc.pathname.includes('search')}
                                    onChange={setSearchItem} 
                                />
                                <div className="filter-icon" onClick={toggleFilter}>
                                    <TuneIcon />
                                    <FilterPanel opened={filterOpen}/>
                                </div>
                            </div>
                            <div className="login-wrapper">
                                {
                                    state?.currentUser?.isAnonymous ? 
                                    <div className="login-btn" onClick={tryLogin}><span>Login</span></div> :
                                    <div className="login-btn" onClick={tryLogout}><span>Logout</span></div>
                                }
                            </div>
                        </div>
                        <Routes>
                            <Route path='/' element={<Home />}/>
                            <Route path='/search' element={<Search />}/>
                            <Route path='/my-library' element={<MyLibrary />}/>
                            <Route path='/playlist/:id' element={<Playlist />}/>
                            <Route path='/playlist' element={<Playlist editMode={true} />}/>
                        </Routes>
                    </div>
                </div>
            </div>
            <Player />
        </div>
    );
}

export default App;