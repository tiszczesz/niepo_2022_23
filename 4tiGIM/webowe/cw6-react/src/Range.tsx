import { useState } from "react";
import "./Range.css"

type RangeProps = {
    colorProps:string;
    indexOfColor:number
    handlerChange:(index:number,value:number)=>void
}

const Range = (props:RangeProps) => {
    const [info,setInfo] = useState("255")
    
    return(
        <div className="border">
        <div style={{color:props.colorProps}}>Kolor {props.colorProps}</div>
        <input onChange={(e)=>{
            setInfo(e.target.value);
            console.log(`info=${e.target.value}`);
            props.handlerChange(props.indexOfColor,parseInt(e.target.value))
        }} type="range" min={0} max={255} value={info} />
        <label>{info}</label>
        </div>
    )
}
export default Range;