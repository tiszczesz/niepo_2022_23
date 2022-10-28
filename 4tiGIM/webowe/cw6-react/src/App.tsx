import Range from './Range';
import './App.css';

function App() {
  const colors = [255,255,255];
  const setColors = (index:number,value:number) =>{
    colors[index] = value;
    console.log(colors)
    document.body.style.backgroundColor = `rgb(${colors[0]},${colors[1]},${colors[2]})`
  }

  return (
    <div className='container'>        
        <Range colorProps='red' handlerChange={setColors} indexOfColor={0}/>
        <Range colorProps='green'  handlerChange={setColors} indexOfColor={1}/>
        <Range colorProps='blue' handlerChange={setColors} indexOfColor={2}/>      
    </div>

  
  );
}

export default App;
