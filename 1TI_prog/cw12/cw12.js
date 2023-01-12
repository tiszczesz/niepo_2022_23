const d1 = document.createElement("div");
d1.innerHTML = "Mój pierwszy element";

const p1 = document.createElement("p");
p1.innerHTML = "To jest paragraf";

document.body.appendChild(d1);
document.querySelector(".container").appendChild(p1);
const ol = document.createElement("ol");

for(let i=1;i<=5;i++){
    const li = document.createElement("li");
    li.innerHTML = `element listy nr ${i}`;
    ol.appendChild(li);
}

document.body.appendChild(ol);