"use strict";
document.querySelector("form")?.addEventListener("submit", (e) => {
    e.preventDefault();
    return false;
});
document.querySelector("#gener")?.addEventListener("click", (e) => {
    document.querySelector("#info").innerHTML = "";
    const quantity = document.querySelector("#ile");
    const text = document.querySelector("#tekst");
    let intOK = ValidateInt(quantity);
    let textOK = ValidateText(text);
    if (intOK && quantity != null && text != null && textOK) {
        document.querySelector("#info")?.appendChild(GenerList(quantity, text));
    }
});
function GenerList(q, text, kind = 'ol') {
    const list = document.createElement("ol");
    for (let i = 0; i < parseInt(q.value); i++) {
        const li = document.createElement("li");
        li.textContent = text.value;
        list.appendChild(li);
    }
    return list;
}
function ValidateInt(elem) {
    if (elem != null && (parseInt(elem.value) < 1 || (parseInt(elem.value) > 100)))
        return false;
    return true;
}
function ValidateText(text) {
    let path = /^[A-ZŁÓŻŚĆŹŃĄĘ]{1}[A-Za-z\s].*/;
    return text != null ? path.test(text?.value) : false;
}
