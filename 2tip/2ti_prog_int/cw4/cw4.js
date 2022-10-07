function Book(title,price,author,category){
    this.title = title;
    this.price = price;
    this.author = author;
    this.category = category;
    this.ShowInPar = function(){
        return `<p>${this.title} ${this.author} ${this.category} cena: ${this.price} PLN</p>`;
    }
}
const books = [
    new Book("Góry polskie",23.99,"Ksawery Bery","podróżnicze"),
    new Book("Wstęp do JS",78.69,"Monika Lewicka","programowanie"),
    new Book("Zaawansowane PHP",123.99,"Monika Lewicka","podróżnicze"),
    new Book("Książka kucharska",53.00,"Roman Boman","poradnik"),
    new Book("Jeziora mazurskie",45.99,"Ksawery Bery","podróżnicze")
]

console.log(books);
