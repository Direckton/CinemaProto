import logo from './logo.svg';
import './App.css';
import Fetch from './Fetch';
import FetchMovies from './FetchMovies';
import { useEffect } from 'react';



function App() {
  return (
    <div className="App">
      <p>Hello from React</p>
      <Fetch />
      <FetchMovies />
    </div>
  );
}

export default App;
