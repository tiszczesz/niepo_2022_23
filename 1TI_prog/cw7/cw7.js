const Contacts = [
    ["Adam","Nowak","dd@onet.pl","22323232"],
    ["Franek","Banek","banek57@onet.pl","3453453"],
    ["Roman","Boman","rom23@onet.pl","353535"],
    ["Eryk","Beryk","weryk@onet.pl","35353453"],
    ["Dorota","Małecka","sdadd@onet.pl","35353535"],
    ["Anna","Wanna","awd@onet.pl","3535355"]
]
console.log(Contacts[2][0],Contacts[2][1]);
console.log(Contacts[5][2]);
document.querySelector("#info").innerHTML = generTab(Contacts);

function generTab(tab){
    //return "GGG";
    let html = "<table>";
    html += "<tr><th>Lp</th><th>Imię</th><th>Nazwisko</th><th>Email</th><th>Telefon</th></tr>";
    // for(let i=0; i<tab.length;i++){
    //     html += `<tr>
    //                   <td>${i+1}</td>
    //                   <td>${tab[i][0]}</td>
    //                   <td>${tab[i][1]}</td>
    //                   <td>${tab[i][2]}</td>
    //                   <td>${tab[i][3]}</td>
    //                 </tr> `;
    // }
    let lp=0;
    tab.forEach(function(e,i){

    });
    return html +"</table>";
}