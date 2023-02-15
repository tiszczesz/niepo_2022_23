class Book {
    constructor(image, author, year, price) {
        this.title = this.GetTitle(image);
        this.image = image;
        this.author = author;
        this.year = year;
        this.price = price
    }
    GetTitle(image) {
        return image.substring(0, image.lastIndexOf('.'));
    }
}
function GenerBook() {
    const books = [];
    images.forEach((v, i) => {
        books.push(new Book(v[0], v[1], v[2], v[3]))
    });
    return books;
}

const images = [
    ["C# 10 i .NET 6 dla programistów aplikacji wieloplatformowych.jpg"
        , "Antoni Małecki", 2021, 67.90],
    ["C++ Zbiór zadań z rozwiązaniami.jpg", "Roman Bałecki", 2019, 45.90],
    ["Czysty Agile. Powrót do podstaw.jpg", "Roman Bałecki", 2019, 89.90],
    ["Etyczny haking.jpg", "Roman Bałecki", 2017, 69.90],
    ["Git i GitHub. Kontrola wersji, zarządzanie projektami i zasady pracy zespołowej.jpg", "Roman Bałecki", 2019, 45.90],
    ["JavaScript i jQuery. Interaktywne strony WWW dla każdego. Podręcznik Front-End Developera.jpg", "Roman Bałecki", 2019, 45.90],
    ["Czysty kod. Podręcznik dobrego programisty.jpg", "Roman Bałecki", 2022, 33.90]
];

const books = GenerBook();
console.log(books);