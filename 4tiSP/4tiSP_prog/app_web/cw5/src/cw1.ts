function Delay(collback: () => void, time: number): void {
    setTimeout(() => {
        collback();
    }, time)
}
// const f1 = ()=>{
//     Delay("Zadanie 1",1000);
//     Delay("Zadanie 2",200);
//     Delay("Zadanie 3",400);
// }
//f1();
const zad3 = () => {
    console.log("Początek działania");
    Delay(() => {
        console.log("Zadanie 1");
        Delay(() => {
            console.log("Zadanie 2");             
            Delay(()=>{
                console.log("Zadanie inne");
                console.log("Koniec działania");
            },300)
        }, 2000);
    }, 1000)       
}
zad3();


