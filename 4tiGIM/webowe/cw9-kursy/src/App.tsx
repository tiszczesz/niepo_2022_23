import React from 'react';
import { Courses } from './dane';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';

const App = () => {
  return (
    <div className="container">
      <h1>Informacje o kursach</h1>
      <div>
        <table className="table table-bordered">
          <tr>
            <th>Nr. kursu</th>
            <th>Tytuł</th>
            <th >Data</th>
            <th>Miejsce</th>
          </tr>
          {Courses.map((elm,i)=>(
            <tr>
              <td>{elm.id}</td>
              <td>{elm.name}</td>
              <td >{elm.date.toLocaleDateString()}</td>
              <td>{elm.place}</td>
            </tr>
          ))}
        </table>
      </div>
    </div>
  );
}

export default App;
