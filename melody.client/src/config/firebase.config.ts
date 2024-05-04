import { initializeApp } from "firebase/app";
import { getAuth, GoogleAuthProvider } from 'firebase/auth';

const firebaseConfig = {
  apiKey: "AIzaSyAVDfOwNTCmSZWjj1PY1KjCHKfQLDS5vto",
  authDomain: "melody-23378.firebaseapp.com",
  projectId: "melody-23378",
  storageBucket: "melody-23378.appspot.com",
  messagingSenderId: "720952025005",
  appId: "1:720952025005:web:691381561d9e4a4122cb24"
};

const app = initializeApp(firebaseConfig);

const auth = getAuth(app);
const provider = new GoogleAuthProvider();

export { auth, provider };