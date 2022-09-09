console.log("Hello from JS");

const todos = [
    "Napisać cały kod",
    "Zapisać zmiany",
    "Otworzyć w przeglądarce","sdfds fs sdfsdf"];
const myDiv = document
     .createElement("div");
myDiv.innerHTML = "<h3>To jest z JS</h3>";
console.log(myDiv);
document.body.appendChild(myDiv);
myDiv.innerHTML += generList(todos);
myDiv.appendChild(createList(todos));


function generList(data){
    let html = "<ul>";
    for(let i=0; i<todos.length; i++){
        html += `<li>${todos[i]}</li>`;
    }

    return html + "</ul>";
}

function createList(data){
    const ol = document.createElement("ol");
    data.forEach(function(v,i){
       // console.log(v,i);
       const li = document.createElement("li");
       const text = document.createTextNode(v);
       li.appendChild(text);
       ol.appendChild(li);
    });
   return ol; 
}

document.querySelector("div").onclick = function(){
    alert("fffff");
}