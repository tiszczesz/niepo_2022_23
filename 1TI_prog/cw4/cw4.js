
document.querySelector("#run").addEventListener("click",function(){
    console.log("click");
    
    let firstname = document.querySelector("#firstname").value;
    document.querySelector("#info").innerHTML = firstname;
});