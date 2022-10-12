const form = document.forms[0];
form.addEventListener("submit",(e)=>{
    const check = document.querySelector("#isCheck");
    console.log(check);
    if(!check.checked){
        e.preventDefault();
        check.style.outline = "1px solid red";
        check.nextElementSibling.style.color = "red";
        return false;
    }
    return true;
});
document.querySelector("#isCheck").addEventListener("click",(e)=>{
    if(!e.target.checked) e.target.nextElementSibling.style.color = "red";
    else e.target.nextElementSibling.style.color = "black";
});