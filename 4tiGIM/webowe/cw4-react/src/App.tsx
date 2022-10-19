import React, { useState } from 'react';
import { divisions } from './data';
import './App.css';
import 'bootstrap/dist/css/bootstrap.css';
import m1 from './media/m1.jpg';
import m2 from './media/m2.jpg';

function App() {
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [divValue, setDivValue] = useState("");
  return (
    <div className="container">
      <h1 className='green'>To maja fajna strona</h1>
      <p style={{ border: 'solid 1px gray', fontStyle: "italic", padding: "8px", textAlign: "center" }}>Hello world</p>
      <div className="row">
        <form className='col'>
          <div className="line">
            <label htmlFor="firstName">Podaj imie: </label>
            <input type="text" id='firstName'
              onChange={(e) => {
                console.log(e.target.value);
                setFirstName(e.target.value);
              }}
              value={firstName} />
          </div>
          <div className="line">
            <label htmlFor="lastName">Podaj nazwisko: </label>
            <input type="text" id="lastName" onChange={(e) => {
              console.log(e.target.value);
              setLastName(e.target.value);
            }} value={lastName} />
          </div>
          <div className="line">
            <label htmlFor="division">Wybierz klasę: </label>
            {/* <input type="text" id="division" onChange={(e) => {
              console.log(e.target.value);
              setdivision(e.target.value);
            }} value={division}/> */}
            <select onChange={(e) => {
              console.log(e.target.value);
              setDivValue(e.target.value)
            }}
            >
              {divisions.map((division, index) => (<option value={division} key={index}>{division}</option>))}
            </select>
          </div>
        </form>
        <div className='col'>
          <img src={m1} alt="m1" />
          <img src={m2} alt="m1" />
        </div>
      </div>
      <h3>Kandydat do szkoły:</h3>
      <div>Imię: {firstName.toUpperCase()} Nazwisko: {lastName.toUpperCase()} klasa: {divValue}</div>
    </div>
  );
}

export default App;
