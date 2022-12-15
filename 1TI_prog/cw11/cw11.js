// function getValueFromSelect(select){
//     return select.value;
// }
 const sel = document.querySelector("#choice");


// const resultChoice = getValueFromSelect(sel);
// console.log(resultChoice);
  
sel.addEventListener("change",(event)=>{
    console.log(event.target.value);
});

document.querySelector("#run").addEventListener("click",()=>{
    console.log(sel.value);
});