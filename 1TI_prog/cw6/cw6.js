const divs = document.querySelectorAll("div.names");

getOnlyEven(divs);
console.log(divs);
const names = [];
divs.forEach(function(e,i){
    names.push(e.innerText.trim());
});
console.log(names);

function getOnlyEven(tab){
    tab.forEach(function(e,i){
        if(i%2==0){
            console.log(e.innerText);
            
        }
    })
}