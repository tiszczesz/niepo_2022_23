//tworzenie obiektow literalnie
const Bolek = {
    //pola czyli właściwości
    login: "Bolek23",
    passward: "qaz",
    email: "bolek@onet.pl",

    //metody czyli zachowania
    showUser: function () {
        return `<p>login: ${Bolek.login} napisz do niego: ${Bolek.email}</p>`;
    },
    sendEmail: function () {
        return "Email na addres: " + this.email + " został wysłany -> czekamy na odpowiedź....";
    }
};
//tworzenie obiektów za pomocą konstruktora
function Book(title, author, price, date) {
    this.title = title;
    this.author = author;
    this.price = price;
    this.date = date;
    this.BookInfo = function () {
        return `<p>
            Tytuł: <span class='info'>${this.title}</span>
            Autor: <span class='info'>${this.author}</span>
            Cena: <span class='info'>${this.price}</span>
            Data wydania: <span class='info'>${this.date.toLocaleDateString()}</span>
            </p>`;
    }
}

console.log(Bolek);
console.log(`login: ${Bolek.login} napisz do niego: ${Bolek.email}`);
const result = document.createElement("div");//utworzenie diva
document.body.appendChild(result); //umieszczenie na stronie
result.innerHTML = Bolek.showUser();
console.log(Bolek.sendEmail());
const b1 = new Book("Wstęp do JS","Roman Boman",34.99,new Date('2021-12-03'));
const div2 = document.createElement("div");
div2.innerHTML = b1.BookInfo();
document.body.appendChild(div2);