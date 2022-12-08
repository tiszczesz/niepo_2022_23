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
    if(n<=1) return 1;
    return silniaRek(n-1)*n;
}
function silniaIter(n){
    if(n<=1) return 1;
    let result = 1;
    for(let i = 1;i <= n; i++){
        result = result * i;
    }
    return result;
}