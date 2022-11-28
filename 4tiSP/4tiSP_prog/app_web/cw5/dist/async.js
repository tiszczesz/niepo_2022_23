"use strict";
const deley3 = (t, v) => {
    return new Promise((resolve) => {
        setTimeout(() => {
            console.log(v);
            resolve();
        }, t);
    });
};
(async function () {
    deley3(3000, "zadanie 1");
    deley3(2000, "zadanie 2");
    deley3(500, "zadanie 3");
})();
