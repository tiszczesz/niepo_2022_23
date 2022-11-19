"use strict";
const promise = new Promise((res, rej) => {
    setTimeout(() => {
        res('zdanie wykonane!');
    }, 3000);
});
promise
    .then((result) => {
    console.log(result);
})
    .then((result) => {
    setTimeout(() => console.log('Zadanie 2'), 4000);
});
