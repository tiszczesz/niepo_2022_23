console.log("sdsdfsf");
document.querySelector("#napis").onchange = function(e){
    console.log("onchange: "+e.target);
};
document.querySelector("#napis").oninput = function(e){
    console.log("oninput: "+e.target);
    document.querySelector("#result1").innerHTML = e.target.value;
}