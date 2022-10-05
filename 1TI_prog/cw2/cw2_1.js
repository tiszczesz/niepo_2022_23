console.log("hello");
const myDiv = document.querySelector("#info");
const myDiv2 = document.querySelector("#info2");
const myH1 = document.querySelector("h1");
console.log(myDiv);
setTimeout(function () {
    // myDiv.innerText = "<h3>ala ma kota</h3>"; 
     myDiv.innerHTML = "<h3>ala ma kota</h3>"; 
     myDiv.style.color = "red";
     myH1.style.color = "green";
    }, 1000);
setTimeout(function () {
    // myDiv.innerText = "<h3>ala ma kota</h3>"; 
     myDiv2.innerHTML = "<h3>Damy radę</h3>"; 
     myDiv2.style.color = "red";
    
    }, 3000);
