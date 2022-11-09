const divs = document.querySelectorAll("div.names");
console.log(divs);
const names = [];
divs.forEach(function(e,i){
    names.push(e.innerText.trim());
});
console.log(names);