const t1 = [1, 4, 5, 6, 8, "ala", true];
document.querySelector("#c1").innerHTML = t1;
console.log(t1[5]);//6 elem tablicy o indeksie 5
console.log(t1[0]);// 1 elem tablicy o indeksie 0
console.log(t1[t1.length - 1]);//ostatni element tablicy
let html = "<ul>";
for (let i = 0; i < t1.length; i++) {
    html += `<li>t1 [ ${i} ] = ${t1[i]}</li>`
}
html += "</ul>";
document.querySelector("#c2").innerHTML = html;
t1.forEach(function(v,i){
    console.log(`i=${i} v=${v}`);
});
for(let elem of t1){
    console.log(elem);
}
for(let elem in t1){
    console.log(elem);
}
t1.push("ostatni");
document.querySelector("#c3").innerHTML = t1;
t1.unshift("pierwszy"); //dodaje na poczatek
console.log(t1);
t1.shift(); //zabiera pierwszy element
console.log(t1);
