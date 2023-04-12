console.log("jquery: ",jQuery(document));
console.log("js: ",document);
$(document).ready(
    ()=>console.log("Hello")
);
$(()=>console.log("Hello2"));
//tradycyjnie js
console.log("p: ",document.querySelector("p"));
const p1 = document.querySelector("p");
console.log(p1.innerHTML);
//jQuery

console.log("p w jQuery:",$("p"));
const p2 = $("p");
console.log(p2.innerHTML);
console.log(p2.html("<h1>Hello from jQuery</h1>"));
$("p").html("ala ma kota");