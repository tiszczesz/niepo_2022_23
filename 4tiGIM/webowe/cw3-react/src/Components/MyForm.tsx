import 'bootstrap/dist/css/bootstrap.css';
import React, { useState } from 'react';

export const MyForm = () => {
  const [email, setEmail] = useState("");
  const handlechange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setEmail(e.target.value)
    console.log(email);


  }
  return (
    <div className="container">
      <form>
        <div className="mb-3">
          <label className="form-label">Email address</label>
          <input type="email" onChange={handlechange} className="form-control" id="exampleInputEmail1" value={email} />
          <div id="emailHelp" className="form-text">We'll never share your email with anyone else.</div>
        </div>
        <div className="mb-3">
          <label className="form-label">Password</label>
          <input type="password" className="form-control" id="exampleInputPassword1" />
        </div>
        <div className="mb-3 form-check">
          <input type="checkbox" className="form-check-input" id="exampleCheck1" />
          <label className="form-check-label">Check me out</label>
        </div>
        <button type="submit" className="btn btn-primary">Submit</button>
      </form>
      <div>{email.toUpperCase()}</div>
    </div>

  );
}