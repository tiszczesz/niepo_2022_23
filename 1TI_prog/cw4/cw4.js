
document.querySelector("#run").addEventListener("click",function(){
    console.log("click");
    
    let firstname = document.querySelector("#firstname").value;
    ClearForm();
    document.querySelector("#info").innerHTML = firstname;
});

function ClearForm(){
    document.querySelector("#firstname").value = "";
    document.querySelector("#lastname").value = "";
    document.querySelector("#division").value = "";
}