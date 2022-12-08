document.querySelector("#oblicz").onclick = function(){
    const n = parseInt(document.querySelector("#n").value);
    if(!isNaN(n)){
        const choice = document.querySelectorAll("input[type=radio]");
        //console.log(choice);
        let metoda = ""
        for(let i=0; i<choice.length;i++){
            if(choice[i].checked) metoda = choice[i].value;
        }
        //console.log(metoda);
    }else{
        document.querySelector("#result").innerHTML = "Blędne dane";
    }
}

function silniaRek(n){

}
function silniaIter(n){
    
}