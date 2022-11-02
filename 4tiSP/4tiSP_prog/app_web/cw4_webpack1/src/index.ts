import { Dane } from './dane'

console.log("Hello from WebPack");
const app = document.querySelector("#app");
if(app!=null){
    app.innerHTML = "ala ma kota";
}

const app2 = document.createElement("div");
let html = "<ol>";
Dane.forEach((e,i)=>{
    html += `<li>${e}</li>`;
});
html += "</ol>";
app!.appendChild(app2);
app2.innerHTML = html;
