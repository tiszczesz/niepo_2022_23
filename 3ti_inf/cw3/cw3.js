const pars = document.querySelectorAll("p");
console.log(pars);
pars[0].style.border = "solid 1px black";
pars[1].style.color = "brown";
pars[2].style.backgroundColor = "yellow";
pars[2].style.border = "solid 1px black";

pars[0].onclick = function(){
    alert("Paragraf pierwszy");
};
pars[1].onclick = function(event){
    console.log(event.target);
    
    if(event.target.style.color != "red"){
        event.target.style.color = "red";
    }else{
        event.target.style.color = "brown";
    }
    
}
pars[2].onclick = function(event){
    console.log("trzeci");
    console.log(event.target.style.border);
    console.log(event.target.style.borderStyle);
    if(event.target.style.borderStyle!="solid"){
        event.target.style.borderStyle = "solid";
    }else{
        event.target.style.borderStyle = "none";
    }
}