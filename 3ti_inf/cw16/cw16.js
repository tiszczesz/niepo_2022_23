//tworzenie obiektow literalnie
const Bolek = {
    //pola czyli właściwości
    login:"Bolek23",
    passward: "qaz",
    email: "bolek@onet.pl",

    //metody czyli zachowania
    showUser: function(){
        return `<p>login: ${Bolek.login} napisz do niego: ${Bolek.email}</p>`;
    },
    sendEmail: function(){
        return "Email na addres: "+this.email+" został wysłany -> czekamy na odpowiedź....";
    }
};

console.log(Bolek);
console.log(`login: ${Bolek.login} napisz do niego: ${Bolek.email}`);
const result = document.createElement("div");//utworzenie diva
document.body.appendChild(result); //umieszczenie na stronie
result.innerHTML = Bolek.showUser();
console.log(Bolek.sendEmail());