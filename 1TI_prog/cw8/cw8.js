document.querySelector("#run").addEventListener("click",function(){
    //console.log("click");
    widthOK = ValidateNumber(document.querySelector("#width"));
    heightOK = ValidateNumber(document.querySelector("#height"));
});

function ValidateNumber(element){
    const next = element.nextElementSibling;
    console.log(next);
    if(!isNaN(parseInt(element.value)) && element.value>=4 && element.value<=100){
        next.innerHTML = "";
        element.classList.remove("input-error");
        return true;
    }else{
        next.innerHTML = "!";
        element.classList.add("input-error");
        return false;
    }
}