import logo from './logo.svg';
import './App.css';

function App(params) {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        
        <p>hola {params.name}</p>
        
      </header>
    </div>
  );
}

export default App;
