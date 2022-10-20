import React from 'react'
import WorkersComp from './WorkersComp';
import {Quotations} from './Data'
import './MyApp.css';
type Props = {
    info:string
}

const  MyApp = ({info}: Props) => {
  return (
    <>
        <h1>{info}</h1>
        <div className="container">
             <ul>
        {Quotations.map((elem,index) =>(
            <li key={index}>{elem}</li>
        ))}
        </ul>
        <WorkersComp />
        </div>
       
    </>
    
  )
}
export default MyApp;