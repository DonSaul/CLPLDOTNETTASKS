import './App.css';
import { AlertForm } from './components/alertform';
import { NameList } from './components/namelist';

function App() {
  const nameList = [
    'Chita MacGuinness',
    'Zlata Ahlström',
    'Solvej Trueman',
    'Mebh Cavanaugh',
    'Edgars Bellerose',
  ];
  return (
    <div className="App">
      <header className="App-header">
        <h1>React Example</h1>{/*HW Task 1*/}
      </header>
      <div className='content'>
        <NameList list={nameList}/>{/*HW Tasks 2-4*/}
        <AlertForm/>{/*HW Task 5*/}
      </div>
    </div>
  );
}

export default App;
