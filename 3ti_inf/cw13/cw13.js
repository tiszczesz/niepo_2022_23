const img = document.querySelector("#obrazek");
img.onmouseenter = function(event){
    event.target.style.opacity = "0";
}
img.onmouseleave = function(event){
    event.target.style.opacity = "1";
}