import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import Compo1 from './MyComponents/Compo1';
import Image from './MyComponents/Image';

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
root.render(
  <React.StrictMode>
    <h1>Adam Nowak</h1>
    <h2>Klasa 4TI</h2>
    <h3>Rok szkolny 2022/23</h3>
    <hr />
    <Compo1 />
    <Image />
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
