document.querySelector("#oblicz").onclick = function(){
    const paliwo = parseInt(document.querySelector("#paliwo").value);
    const litry = parseInt(document.querySelector("#litry").value);
    if (isNaN(paliwo) || isNaN(litry)) {
        document.querySelector("#result").innerHTML = "błędne dane";
        return;
    }
    switch(paliwo){
        case 1: document.querySelector("#result").innerHTML = `koszt paliwa: ${litry*4} zł`; break;
        case 2: document.querySelector("#result").innerHTML = `koszt paliwa: ${litry*3.5} zł`; break;
        default: document.querySelector("#result").innerHTML = `koszt paliwa: Błędne dane`; break;
    }
   
};