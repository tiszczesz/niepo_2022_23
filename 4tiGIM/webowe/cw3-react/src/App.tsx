import React from 'react';
import 'bootstrap/dist/css/bootstrap.css'
import './App.css';
import { CardComponent } from './Components/CardComponent';
import { BrowserRouter, Routes, Route, Link } from "react-router-dom";
import { AnotherComponent } from './Components/AnotherComponent';

function App() {
  return (
    <>
      <BrowserRouter>
        <div>
          <Link className='link' to="/">Strona Card</Link> 
          <Link className='link' to="another">Strona Another</Link>
        </div>
        <Routes>
          <Route path='/' element={<CardComponent />} />
          <Route path='another' element={<AnotherComponent />} />
        </Routes>

      </BrowserRouter>

    </>
  );
}

export default App;
