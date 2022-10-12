//alert("fffff");

const elem = document.querySelector('form').addEventListener("submit",(e)=>{
    let elemFirst = document.querySelector("#firstname");
    let elemLast = document.querySelector("#lastname");
    let elemAge = document.querySelector("#age");
    console.log(elemFirst);
    let firstOK = Validate(elemFirst);
    let lastOK = Validate(elemLast);
    let ageOK = ValidateAge(elemAge);
    if(firstOK && lastOK && ageOK) return true;
    e.preventDefault();
    console.log("próba submita");
    return false;
});
//console.log(elem);
function Validate(elem){
    const next = elem.nextElementSibling;
    if(elem.value.trim().length>0){
        next.innerHTML = "";
        return true;
    }
    next.innerHTML = "Błędne dane!!!";
    return false;
}
function ValidateAge(elem){
    const next = elem.nextElementSibling;
    let age = parseInt(elem.value);
    if(!isNaN(age) && age>=18){
        next.innerHTML = "";
        return true;
    }
    next.innerHTML = "Za młody lub błędny wiek";
    return false;
}
