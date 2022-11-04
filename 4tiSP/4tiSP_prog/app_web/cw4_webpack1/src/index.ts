console.log("Hello from Webpack");

const Users = ["Admin","Prof","Student","Inny","Winny"];
const app = document.querySelector("#app");

const ol = document.createElement("ol");
ol.className = "list-group";
Users.forEach((e,i)=>{
    const li = document.createElement("li");
    li.innerHTML = e;
    li.className = "list-group-item";
    ol.appendChild(li);
})
if(app!==null){
    app.innerHTML = "Teraz coś nowego";
    app.appendChild(ol);
}
