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
        return true;
    }else{
        next.innerHTML = "!";
        return false;
    }
}