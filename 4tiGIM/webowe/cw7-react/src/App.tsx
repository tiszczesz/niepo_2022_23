import React from 'react';

import './App.css';

function App() {
  return (
    <div className='container'>
      <div>
        <input type="range" name="height" id="height" min={100} max={300} /><br />
        <input type="range" name="width" id="width" min={100} max={300}/>
      </div>
      <div className='rectangle' style={{width:"200px",height:"300px"}}></div>
    </div>
  );
}

export default App;
