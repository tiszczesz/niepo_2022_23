const elem = document.querySelector("#elem");
const text = document.querySelector("#text");
elem.onmouseenter = function(event){
    console.log(`zdarzenie mouseenter:`,event);
    text.innerHTML = "Wskaźnik myszki w kwadracie";
}
elem.onmouseleave = function(event){
    console.log('zdarzenie mouseleave: ',event);
    text.innerHTML = "Wskaźnik myszki po za kwadratem";
}
elem.onmousedown = function(event){
    console.log(`wciśnięcie przycisku:`,event);
    //text.innerHTML = "Wskaźnik myszki w kwadracie";
}
elem.onmouseup = function(event){
    console.log('puszczenie przycisku: ',event);
    //text.innerHTML = "Wskaźnik myszki po za kwadratem";
}