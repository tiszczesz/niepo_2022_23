const dts = document.querySelectorAll("dt");
console.log(dts);
for(let i=0;i<dts.length;i++){
    dts[i].onclick = function(e){
        console.log(e.target.nextElementSibling.innerHTML);
        if(e.target.nextElementSibling.style.display != "block"){
            e.target.nextElementSibling.style.display = "block";
        }else{
            e.target.nextElementSibling.style.display = "none";
        }
        
    }
}