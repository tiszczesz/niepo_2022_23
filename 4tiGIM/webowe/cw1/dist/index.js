import { todos } from "./data.js";
document.querySelector("#go")?.addEventListener("click", (e) => {
    const divFirst = document.createElement("div");
    divFirst.innerHTML = getList(todos);
    document.querySelector("#app")?.appendChild(divFirst);
});
function getList(data) {
    let html = "<table class='table table-striped'>";
    data.forEach((v, i) => {
        const style = !v.isChecked ? "style='color:red'" : "";
        html += `<tr ${style}><td>${v.id}</td><td>${v.name}</td></tr>`;
    });
    html += "</table>";
    return html;
}
