import React, { useState } from 'react'
import {Workers} from './Data'
import WorkerInfoComp from './WorkerInfoComp';
type Props = {
  
}

const WorkersComp = (props: Props) => {
  const [info,setInfo] = useState<string[]>([]);
  return (
    <div className='workers'>
    <ol >
      {Workers.map((elem,index) => (
        <li style={{cursor:"pointer"}} onClick={(e)=>{
          console.log(elem.Show());
          setInfo(elem.Show())
        }}
         key={index} >{elem.lastname} {elem.firstname}</li>
      ))}
    </ol>
    <WorkerInfoComp personInfo={info} />
    </div>
  )
}
export default  WorkersComp;