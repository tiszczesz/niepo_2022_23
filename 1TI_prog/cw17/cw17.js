document.querySelector("#choice1").addEventListener("change",(e)=>{
    document.querySelector("#first").className = e.target.value;
});
const checks = document.querySelectorAll("input[type=checkbox]");
console.log(checks);
checks.forEach((v,i)=>{
    v.addEventListener("click",(e)=>{
        console.log(e.target.value);
        console.log(document.querySelector("#second").classList);
        document.querySelector("#second").classList.toggle(e.target.value);
    });
});

console.log(mm);
console.log(ff);