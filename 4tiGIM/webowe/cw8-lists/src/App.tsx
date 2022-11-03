import React, { useState } from 'react';
import 'bootstrap/dist/css/bootstrap.css'
import './App.css';
import { MyList } from './data'

function App() {
  const [info, setInfo] = useState('');
  const [list,setList] = useState(MyList);
  return (
    <div className='container'>
      <h1>Moja lista</h1>
      <ol className='list-group'>
        {list.map((v, i) => (
          <li className='list-group-item' key={i}>{v}</li>
        ))}
      </ol>
      <div className='row'>
        <label className='col-2 text-end m-2' htmlFor="name">Podaj imię</label>
        <input onChange={
          (e)=>{setInfo(e.target.value);
            console.log(info);            
          }
          } className='col m-2' type="text" name="name" id="name" value={info} />
        <input className='col m-2' type="button" value="Dodaj" 
          onClick={(e)=>{
            setList([...list,info]);
            setInfo('')
          }}
        />
      </div>
    </div>
  );
}

export default App;
