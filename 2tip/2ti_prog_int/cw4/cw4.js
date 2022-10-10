function Book(title, price, author, category) {
    this.title = title;
    this.price = price;
    this.author = author;
    this.category = category;
    this.ShowInPar = function () {
        return `<p>${this.title} ${this.author} ${this.category} cena: ${this.price} PLN</p>`;
    }
    this.ShowInRow = function (lp) {
        return `<tr>
            <td>${lp}</td>
            <td>${this.title}</td> 
            <td>${this.author}</td> 
            <td>${this.category}</td> 
            <td  class="text-end">${this.price.toFixed(2)}</td>
        </tr>`;
    }
}
const books = [
    new Book("Góry polskie", 23.99, "Ksawery Bery", "podróżnicze"),
    new Book("Wstęp do JS", 78.69, "Monika Lewicka", "programowanie"),
    new Book("Zaawansowane PHP", 123.99, "Monika Lewicka", "podróżnicze"),
    new Book("Książka kucharska", 53.00, "Roman Boman", "poradnik"),
    new Book("Jeziora mazurskie", 45.99, "Ksawery Bery", "podróżnicze")
]
function GenerTab(data,className){
    let html = `<table class='${className}'>`;
    let lp = 0;
    html += '<tr><th>Lp</th><th>Tytuł</th><th>Autor</th><th>Gatunek</th><th>Cena</th></tr>';
    data.forEach(element => {
        html += element.ShowInRow(++lp);
    });

    return html+"</table>";
}
document.querySelector("#root").innerHTML = GenerTab(books,'table');


console.log(books);
