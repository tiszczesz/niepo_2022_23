import React from 'react';
import 'bootstrap/dist/css/bootstrap.css'
import './App.css';
import { CardComponent } from './Components/CardComponent';
import { BrowserRouter, Routes, Route, Link, } from "react-router-dom";
import { AnotherComponent } from './Components/AnotherComponent';
import { MyForm } from './Components/MyForm';

function App() {
  return (
    <>
      <BrowserRouter>
        <div>
          <Link className='link' to="/">Strona Card</Link> 
          <Link className='link' to="another">Strona Another</Link>
          <Link className='link' to='myForm'>formularz</Link>
        </div>
        <Routes>
          <Route path='/' element={<CardComponent />} />
          <Route path='another' element={<AnotherComponent />} />
          <Route path='myForm' element={<MyForm />} />
        </Routes>

      </BrowserRouter>

    </>
  );
}

export default App;
