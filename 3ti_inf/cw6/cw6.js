console.log("sdsdfsf");
document.querySelector("#napis").onchange = function (e) {
    console.log("onchange: " + e.target);
};
document.querySelector("#napis").oninput = function (e) {
    console.log("oninput: " + e.target);
    document.querySelector("#result1").innerHTML = e.target.value.toUpperCase();
}
document.querySelector("#napis2").oninput = function(e){
    if(e.target.value.trim().length>2){
        e.target.classList.remove("error");
    }else{
        e.target.className = "error";
    }
};