const t1 = [
    "ala", "bela", "cela", "mela", 34, true,
    {
        name: "Jan",
        email: "jan@gmail.com"
    }
];
console.log(t1);
document.querySelector("#info1").innerHTML = "Element tablicy o indeksie 2: "+t1[2];
document.querySelector("#info2").onclick = function(event){
    console.log(event.target.innerHTML);
    event.target.innerHTML = getElements(t1,4);
};
function getElements(tab,count){
    count = count >= tab.length ?  tab.length: count;
    let html = "";
    for(let i=0; i<count;i++){
        html += tab[i]+" ";
    }
    return html;
}
t1.push("nowy na końcu tablicy");
document.querySelector("#info3").innerHTML = getElements(t1,t1.length);
t1.unshift("na początek tablicy");
document.querySelector("#info4").innerHTML = getElements(t1,t1.length);
//usuwanie z końca tablicy
t1.pop();
console.log(t1);