class Book {
    constructor(id,image, author, year, price) {
        this.id  = id
        this.title = this.GetTitle(image);
        this.image = image;
        this.author = author;
        this.year = year;
        this.price = price
    }
    GetTitle(image) {
        return image.substring(0, image.lastIndexOf('.'));
    }
    BookToCard(){
        const card = document.createElement("div");
        card.id = this.id;
        card.className = "card m-2";
        card.style.width = "250px";
        const cardBody = document.createElement("div");
        cardBody.className = "card-body";
        cardBody.innerHTML = `<div>Cena: ${this.price} zł </div>
        <div>Autor: ${this.author}</div><div>Rok wydania: ${this.year}</div>`;
        const cardTitle = document.createElement("div");
        cardTitle.className = "card-title text-center fw-bold";
        cardTitle.innerHTML = this.title;
        card.appendChild(cardTitle);
        const cardImage = document.createElement("img");
        cardImage.src = 'images/'+this.image;
        card.appendChild(cardImage);
        card.appendChild(cardBody);
        return card;
    }
}
function GenerBook() {
    const books = [];
    booksInfo.forEach((v, i) => {
        books.push(new Book(`id_${i}`,v[0], v[1], v[2], v[3]))
    });
    return books;
}

const booksInfo = [
    ["C 10 i .NET 6 dla programistów aplikacji wieloplatformowych.jpg"
        , "Antoni Małecki", 2021, 67.90,"nkg fydh jcfhjg fhgg jhgjfjhgjfhj hj"],
    ["C++ Zbiór zadań z rozwiązaniami.jpg", "Roman Bałecki", 2019, 45.90],
    ["Czysty Agile. Powrót do podstaw.jpg", "Roman Bałecki", 2019, 89.90],
    ["Etyczny haking.jpg", "Roman Bałecki", 2017, 69.90],
    ["Git i GitHub. Kontrola wersji, zarządzanie projektami i zasady pracy zespołowej.jpg",
        "Roman Bałecki", 2019, 45.90],
    ["JavaScript i jQuery. Interaktywne strony WWW dla każdego. Podręcznik Front-End Developera.jpg",
        "Roman Bałecki", 2019, 45.90],
    ["Czysty kod. Podręcznik dobrego programisty.jpg", "Roman Bałecki", 2022, 33.90]
];

const books = GenerBook();
console.log(books);
const bookDiv = document.querySelector(".books");
books.forEach((v,i)=>{
    bookDiv.appendChild(v.BookToCard());
});
const info = document.querySelector(".info");
const cards = document.querySelectorAll(".card");
console.log(cards);
cards.forEach((v,i)=>{
    v.addEventListener("mouseenter",(event)=>{
       // console.log("mouseenter: ",event.target);
      //  console.log(v.id);
        const book = books.filter((b)=>{      // (x,y)=>(x+y)
            return b.id===v.id;  //dodoałem return
        });
        console.log(book);
        info.innerHTML = `<h3>Wybrana książka:</h3> Tytuł: <span class='content'>${book[0].title}</span>
        <br>
        Autor: <span class='content'>${book[0].author}</span>
        <br>
        Cena: <span class='content'>${book[0].price} zł</span>`;
    });
    v.addEventListener("mouseleave",(event)=>{
        console.log("mouseleave: ",event.target.firstChild.innerHTML);
        info.innerHTML = "";
        
    });
})
