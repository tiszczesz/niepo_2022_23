import { Todos } from './dane';
console.log("Hello from PARCEL");
console.log(Todos);

const app = document.querySelector("#app");
if(app!==null){
    app.appendChild(generList(Todos))
}

function generList(data:Array<string>):HTMLUListElement{
    
    const list = document.createElement("ul");
    list.className = "list-group"
    data.forEach((e,i)=>{
        const li = document.createElement("li");
        li.className = "list-group-item d-flex";
        const span = document.createElement("span");
        span.innerText = `${e}` ;
        const kosz = document.createElement("img");
        kosz.className = "kosz";
        kosz.src= new URL("./media/delete.png",import.meta.url).toString()
        li.appendChild(span);
        li.appendChild(kosz);       
        list.appendChild(li);
    });
    return list;
}