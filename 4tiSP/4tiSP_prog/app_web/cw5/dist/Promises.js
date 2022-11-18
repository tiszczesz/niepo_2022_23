"use strict";
function Delay2(collback, txt, time) {
    setTimeout((txt) => {
        collback(txt);
    }, time);
}
const zad1 = (txt) => {
    console.log(txt);
    return txt;
};
const resolve = (txt, time) => {
    console.log(txt);
    Delay2((txt) => { zad1(txt); }, txt, time);
};
const reject = () => {
    console.log("ERROR");
};
let value;
const myPromise = new Promise((res, reject) => {
    res(value);
    // reject();
});
myPromise.then((value) => {
    Delay2((value) => { }, "asasas", 4000);
}).then(() => {
    resolve("zadanie 3", 400);
});
