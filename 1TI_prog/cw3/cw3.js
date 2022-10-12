const a = parseFloat(prompt("podaj a"));
const b = parseFloat(prompt("podaj b"));
document.querySelector("#info").innerHTML = Hello("Franek");
const element = document.querySelector("#info4");
if(element!=null){
    setInterval(function(){
        changeColor(element);
    },200);
}
//Add("#info2",a,b);
Add("#info3",a,b);
function Hello(text){
    console.log("from Hello()");
    return "Hello: "+text;
}
function Add(selector,liczba1,liczba2){
    const elem = document.querySelector(selector);
    if(elem==null) {
        console.log("blędny selector!!!");
        return;
    }
    elem.innerHTML = `${liczba1} + ${liczba2} = ${liczba1+liczba2}`;
}
function changeColor(elem){
    //console.log(elem);
    let red = Math.floor(Math.random()*256);
    let green = Math.floor(Math.random()*256);
    let blue = Math.floor(Math.random()*256);
    elem.style.color = `rgb(${red},${green},${blue})`;
}
