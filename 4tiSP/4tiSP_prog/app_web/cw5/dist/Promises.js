"use strict";
const promise = new Promise((res, ejc) => {
    setTimeout(() => {
        res("Zadanie zrealizowane!!!");
    }, 3000);
});
promise.then((result) => {
    console.log(result);
}).then(() => {
    setTimeout(() => { console.log('zadanie 2'); }, 1000);
}).then(() => console.log("Zadanie końcowe"));
