import React from 'react';
import {Courses } from './dane';
import './App.css';

function App() {
  return (
    <p>{Courses[Courses.length-1].info()}</p>
  );
}

export default App;
