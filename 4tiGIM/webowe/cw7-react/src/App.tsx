import React, { useState } from 'react';

import './App.css';

function App() {
  const [width,setWidth]=useState("100");
  const [height,setHeight]=useState("100");
  return (
    <div className='container'>
      <div>
        <input type="range" name="height" id="height" min={100} max={300} 
        onChange={(e)=>{
          setHeight(e.target.value)
        }}
        /><br />
        <input type="range" name="width" id="width" min={100} max={300} 
        onChange={(e)=>{
          setWidth(e.target.value)
        }}
        />
      </div>
      <div className='rectangle' style={{width:width+"px",height:height+"px"}}>
        <span>{width} x {height}</span>
        </div>
    </div>
  );
}

export default App;
