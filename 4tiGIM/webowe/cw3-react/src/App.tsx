import React from 'react';
import 'bootstrap/dist/css/bootstrap.css'
import './App.css';
import { CardComponent } from './Components/CardComponent';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import { AnotherComponent } from './Components/AnotherComponent';

function App() {
  return (
    <BrowserRouter>
    <Routes>
       <Route path='/' element={<CardComponent/>} />
       <Route path='another' element={<AnotherComponent/>}/>
    </Routes>
     
   </BrowserRouter>
  );
}

export default App;
