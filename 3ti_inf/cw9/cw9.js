document.querySelector("#oblicz").onclick = function(){
    const n = parseInt(document.querySelector("#n").value);
    if(!isNaN(n)){
        const choice = document.querySelectorAll("input[type=radio]");
        const metoda2 = document.querySelector("input[type=radio]:checked").value;
        console.log(metoda2);
        let metoda = ""
        for(let i=0; i<choice.length;i++){
            if(choice[i].checked) metoda = choice[i].value;
        }
        //console.log(metoda);
        if(metoda==='iter'){
            //silniaIter(n)
        }else{
            //silniaRek(n)
        }
    }else{
        document.querySelector("#result").innerHTML = "Blędne dane";
    }
}

function silniaRek(n){

}
function silniaIter(n){
    
}