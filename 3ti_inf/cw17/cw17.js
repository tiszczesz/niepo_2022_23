const games = [
    ["Wiedźmin 3", 45.90, 2015, "Fajne RPG"],
    ["GRAT V", 120.90, 2015, "Fajne FPS"],
    ["Diablo 3", 66.90, 2015, "Takie sobie HnS"],
    ["FIFA 2022", 210.90, 2022, "Sprtowa"],
    ["Baldurs Gate 3", 170.90, 2020, "Jeszcze nie wydane RPG"]
]
//todo
//1. napisać Funkcję Tworzącą obiekt Game -> konstruktor
//2. W Game napisać metodę dodającą wiersz do tabelki (dla ambitnych)
function Game(title, price, date, description) {
    this.title = title;
    this.date = date;
    this.price = price;
    this.description = description;

    this.AddToTable = function (table) {
        const row = table.insertRow();
        row.innerHTML = `<td>${this.title}</td>
                        <td class='right'>${this.price.toFixed(2)} </td>
                        <td class='right'>${this.date}</td>                                        
                        <td>${this.description}</td>`;
    }
}
const myGames = [];
for (const row of games) {
    myGames.push(new Game(row[0], row[1], row[2], row[3]));
}
console.log(myGames);
const table = document.querySelector(".table");
for (const g of myGames) {
    g.AddToTable(table);
}