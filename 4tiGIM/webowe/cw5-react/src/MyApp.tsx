import React from 'react'
import {Quotations} from './Data'
type Props = {
    info:string
}

const  MyApp = ({info}: Props) => {
  return (
    <>
        <h1>{info}</h1>
        <ul>
        {Quotations.map((elem,index) =>(
            <li key={index}>{elem}</li>
        ))}
        </ul>
    </>
    
  )
}
export default MyApp;