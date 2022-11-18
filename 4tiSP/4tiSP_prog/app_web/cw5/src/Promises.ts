function Delay2(collback: (txt:string) =>void,txt:string, time: number): void {
    setTimeout((txt:string) => {
        collback(txt);
    }, time)
}
const zad1 = (txt:string) =>{
    console.log(txt);
    return txt;
    
}
const resolve = (txt:string,time:number)=>{   
    console.log(txt);
     
    Delay2((txt)=>{zad1(txt);},txt,time);
}
const reject = ()=>{
    console.log("ERROR");
}
let value: unknown;
const myPromise = new Promise((res,reject)=>{
    res(value);
  
    
   // reject();
});

myPromise.then((value)=>{
    Delay2((value)=>{},"asasas",4000)
}).then(()=>{
    resolve("zadanie 3",400);
});