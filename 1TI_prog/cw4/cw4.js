
document.querySelector("#run").addEventListener("click", function () {
    console.log("click");
    let firstname = document.querySelector("#firstname");
    let lastname = document.querySelector("#lastname");
    let division = document.querySelector("#division");
    document.querySelector("#info").innerHTML = SetInfo(firstname, lastname, division);
   // ClearForm();
    //document.querySelector("#info").innerHTML = firstname;
});

function ClearForm() {
    document.querySelector("#firstname").value = "";
    document.querySelector("#lastname").value = "";
    document.querySelector("#division").value = "";
}
function SetInfo(fnamem, lname, divname) {
    const firstNameOK = ValidateInput(fnamem);
    const lastNameOK = ValidateInput(lname);
    const divisionOK = ValidateInput(divname);
    if (!firstNameOK || !lastNameOK || !divisionOK) return "BRAK LUB NIEPEŁNE DANE!!!"
    return `<div>Imię: ${fnamem.value}</div><div>Nazwisko: ${lname.value}</div><div>Klasa:
                                     ${divname.value}</div>`
}
function ValidateInput(element) {
    if (element.value.trim() == '') {
        element.className = "error";
        return false;
    }
    element.className = "ok";
    return true;
}