"use strict";
const deley2 = (t, v) => {
    return new Promise((res) => {
        setTimeout(() => {
            console.log(v);
            // res()
        }, t);
    });
};
deley2(3000, "Zadanie 1")
    .then((res) => {
    return deley2(2000, "zadanie 2");
})
    .then((res) => {
    return deley2(200, "zadanie 3");
});
