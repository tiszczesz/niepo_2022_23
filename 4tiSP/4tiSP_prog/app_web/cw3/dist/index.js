import { Dane, Users } from "./data.js";
const app = document.querySelector(".app");
app.innerHTML = generTab(Users);
function generTab(dane) {
    let html = "<table class='table table-striped'>";
    html += "<tr><th>Lp</th><th>id</th><th>name</th><th>username</th>"
        + "<th>email</th><th>phone</th><th>website</th></tr>";
    let lp = 0;
    dane.forEach((elem) => {
        lp++;
        html += "<tr>";
        html += `<td>${lp}</td>`;
        html += `<td>${elem.id}</td>`;
        html += `<td>${elem.name}</td>`;
        html += `<td>${elem.username}</td>`;
        html += `<td>${elem.email}</td>`;
        html += `<td>${elem.phone}</td>`;
        html += `<td>${elem.website}</td>`;
        html += "</tr>";
    });
    return html + "</table>";
}
console.log(app);
console.log(Dane);
console.log(Users);
