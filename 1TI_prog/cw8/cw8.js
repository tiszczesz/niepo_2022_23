document.querySelector("#run").addEventListener("click",function(){
    //console.log("click");
    widthOK = ValidateNumber(document.querySelector("#width"));
    heightOK = ValidateNumber(document.querySelector("#height"));
    if(widthOK && heightOK){
        let cols = parseInt(document.querySelector("#width").value);
        let rows = parseInt(document.querySelector("#height").value);
        document.querySelector(".scene").innerHTML = generTab(cols,rows);
    }
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
function generTab(cols,rows){
    let html = "<table>";
    for(let i=0;i<rows;i++){
        html += "<tr>";
        for(let j=0;j<cols;j++){
            html += "<td></td>";
        }
        html += "</tr>";
    }

    return html + "</table>";
}