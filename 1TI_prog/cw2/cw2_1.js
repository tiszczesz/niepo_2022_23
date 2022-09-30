console.log("hello");
const myDiv = document.querySelector("#info");
const myH1 = document.querySelector("h1");
console.log(myDiv);
setTimeout(function () {
    // myDiv.innerText = "<h3>ala ma kota</h3>"; 
     myDiv.innerHTML = "<h3>ala ma kota</h3>"; 
     myDiv.style.color = "red";
     myH1.style.color = "green";
    }, 1000);
