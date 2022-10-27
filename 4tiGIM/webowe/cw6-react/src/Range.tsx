import { useState } from "react";
import "./Range.css"

type RangeProps = {
    colorProps:string;
    
}

const Range = (props:RangeProps) => {
    const [info,setInfo] = useState("0")
    
    return(
        <div className="border">
        <div style={{color:props.colorProps}}>Kolor {props.colorProps}</div>
        <input onChange={(e)=>{
            setInfo(e.target.value);
           
        }} type="range" min={0} max={255} value={info} />
        <label>{info}</label>
        </div>
    )
}
export default Range;