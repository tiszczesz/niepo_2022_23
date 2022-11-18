function Delay2(collback: (txt:string) => string, time: number): void {
    setTimeout((txt:string) => {
        collback(txt);
    }, time)
}
const zad1 = (txt:string) =>{
    console.log(txt);
    return txt;
    
}
const resolve = (txt:string)=>{
    Delay2((txt)=>{return zad1(txt)},66);
}
const reject = ()=>{
    console.log("ERROR");
}
let value: unknown;
const zad = new Promise((res,reject)=>{
    res(value);

    reject();
});

zad.then((zad1)=>{
    console.log(zad1);
    
});