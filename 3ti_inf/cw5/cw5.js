document.querySelector("#show").onclick= function(){
    const choinka = document.querySelector("img");
    console.log(choinka)
    if(choinka.className != "show"){
        choinka.className = "show";
    }else{
        choinka.className = "hide";
    }
 }