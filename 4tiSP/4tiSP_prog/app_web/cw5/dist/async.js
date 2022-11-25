"use strict";
const deley3 = (t, v) => {
    return new Promise((res) => {
        setTimeout(() => {
            console.log(v);
            res();
        }, t);
    });
};
(async function () {
    await deley3(3000, "zadanie 1");
    await deley3(2000, "zadanie 2");
    await deley3(1000, "zadanie 3");
})();
