import React from 'react';
import 'bootstrap/dist/css/bootstrap.css'
import './App.css';

function App() {
  return (
    <div className='container'>
      <div className="card" >
        <div className="card-body">
          <h5 className="card-title" style={{ color: "green" }}>Okno główne</h5>
          <h6 className="card-subtitle mb-2 text-muted">Fajne okno</h6>
          <p className="card-text">Lorem ipsum dolor sit amet consectetur adipisicing elit. Ullam dicta optio aliquam porro, quam voluptatibus quas pariatur repudiandae. Quidem, corporis laudantium? Reiciendis nisi, deserunt consequatur repellat in error odit porro!.</p>
          <a href="#" className="card-link">Card link</a>
          <a href="#" className="card-link">Another link</a>
        </div>
      </div>
    </div>
  );
}

export default App;
