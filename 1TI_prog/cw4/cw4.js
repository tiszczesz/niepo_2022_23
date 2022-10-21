
document.querySelector("#run").addEventListener("click",function(){
    console.log("click");
    
    let firstname = document.querySelector("#firstname").value;
    let lastname = document.querySelector("#lastname").value;
    let division = document.querySelector("#division").value;
    document.querySelector("#info").innerHTML = SetInfo(firstname,lastname,division);
    ClearForm();
    //document.querySelector("#info").innerHTML = firstname;
});

function ClearForm(){
    document.querySelector("#firstname").value = "";
    document.querySelector("#lastname").value = "";
    document.querySelector("#division").value = "";
}
function SetInfo(fnamem,lname,divname){
    if(fnamem.trim()==='' || lname.trim()==='' || divname.trim()==='' ) return "BRAK LUB NIEPEŁNE DANE!!!"
    return `<div>Imię: ${fnamem}</div><div>Nazwisko: ${lname}</div><div>Klasa: ${divname}</div>`
}