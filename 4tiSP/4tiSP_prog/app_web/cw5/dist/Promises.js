"use strict";
function Delay2(collback, time) {
    setTimeout((txt) => {
        collback(txt);
    }, time);
}
const zad1 = (txt) => {
    console.log(txt);
    return txt;
};
const resolve = (txt) => {
    Delay2((txt) => { return zad1(txt); }, 66);
};
const reject = () => {
    console.log("ERROR");
};
let value;
const zad = new Promise((res, reject) => {
    res(value);
    reject();
});
zad.then((zad1) => {
    console.log(zad1);
});
