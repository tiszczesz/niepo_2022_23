## Instrukcja
1. Utworzyć plik z tablicą cytatów 5 lub więcej
2. Utworzyć komponent App w którym będzie generowana lista ul z tymi cytatami
3. Do pliku z danym dołożyć tablicę oboiektów Person
```ts
class Person{
    firstname: string;
    lastname: string;
    age: number;
    //dla ambitnych
    interests:string[];
    constructor(firstname:string, lastname:string, age: number){
        this.firstname = firstname;
        .....
    }
    function Show():string{
        // zwraca string z inforamcjami o osobie
    }
}
// tablica 5 obiektów typu Person
```
4. Utworyć komponent <Workers /> zawierający listę numerowaną osób (imie nazwisko)
5. Kliknięcie w element listy wyświetla obok szczegóły osoby