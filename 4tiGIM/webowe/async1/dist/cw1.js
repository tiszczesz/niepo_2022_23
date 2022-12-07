"use strict";
const delay = (t, napis) => {
    return new Promise((res) => {
        setTimeout(() => {
            console.log(napis);
            //res();            
        }, t);
    });
};
// delay(3000,"Zadanie 1")
// .then((res)=>{
//     return delay(1000,"zadanie 2");
// })
// .then((res)=>{
//     return delay(2000,"zadanie 3");
// })
(async function () {
    await delay(3000, "Zadanie 11");
    delay(1000, "Zadanie 22");
    await delay(300, "Zadanie 33");
})();
delay(300, "Zadanie koncowe");
