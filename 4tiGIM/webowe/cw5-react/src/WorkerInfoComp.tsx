import { info } from 'console'
import React from 'react'

type Props = {
    personInfo:string[]
}

const WorkerInfoComp = (props: Props) => {
  return (
    <div className='info'>
        <ul>
            {props.personInfo.map((elem,index) => (
                <li key={index}>{elem}</li>
            ))}
        </ul>
    </div>
  )
}

export default WorkerInfoComp