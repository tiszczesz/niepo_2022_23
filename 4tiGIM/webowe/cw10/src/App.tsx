import React from 'react';
import DateShow from './components/DateShow';
import 'bootstrap/dist/css/bootstrap.css';
import './App.css';
import NWDComponent from './components/NWDComponent';

function App() {
  return (
    <div className='container' >
      
     <DateShow myColor='red' userName='Bolek'/>
     <DateShow myColor='green' userName='Lolek'/>
     <DateShow myColor='blue' userName='Tola'/>
     <hr />
     <NWDComponent />
    </div>
  );
}

export default App;
