const t1 = ["ala ma kota","inny element","blblbl"];
document.querySelector("#add").onclick = function(){
    //todo
};
function generList(dane){
    let html = "<ul>";
    for(const elem of dane){
        html += `<li>${elem}</li>`;
    }
    return html + "</ul>";
}
document.querySelector("#table").innerHTML = generList(t1);