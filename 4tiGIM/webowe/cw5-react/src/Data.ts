export const Quotations = [
    "To, że milczę, nie znaczy, że nie mam nic do powiedzenia. ",
    "Czytanie książek to najpiękniejsza zabawa, jaką sobie ludzkość wymyśliła",
    "Dobrze widzi się tylko sercem. Najważniejsze jest niewidoczne dla oczu ",
    "W chwili, kiedy zastanawiasz się czy kogoś kochasz, przestałeś go już kochać na zawsze. ",
    "Kocha się za nic. Nie istnieje żaden powód do miłości."
];

class Person {
    constructor(firstname: string, lastname: string, age: number,intersts:string[]=[]) {
        this.firstname = firstname;
        this.lastname = lastname;
        this.age = age;
        this.interests = intersts
    }
    firstname: string;
    lastname: string;
    age: number;
    //dla ambitnych
    interests: string[] = ["sport","muzyka","taniec"];

    Show(): string[] {
        return [
            "Imię: "+this.firstname,
            "Nazwisko: "+this.lastname,
            "Wiek: "+this.age,
            "Zainteresowania: "+this.interests
        ]
    }
}
export const Workers = [
    new Person("Adam","Nowak",34,["Ryby","Kino","Książki"]),
    new Person("Monika","Lewicka",22,["Taniec","Kino","Imprezy"]),
    new Person("Roman","Boman",34,["Góry","Kino","Relaks"]),
    new Person("Teresa","Metresa",34,["Wycieczki","Kino"]),
]