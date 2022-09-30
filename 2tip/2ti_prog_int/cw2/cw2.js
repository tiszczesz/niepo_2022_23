const inputs = document.querySelectorAll("input[type=range]");
//console.log(inputs);
inputs.forEach((elem, i) => {
    elem.previousElementSibling.style.color = elem.id;
    console.log(elem.value);
    elem.addEventListener("input", (e) => {
        console.log(e.target.value);
        setColor(inputs);

    });
});
setColor(inputs);
function setColor(data) {
    document.querySelector("#square")
        .style.backgroundColor = `rgb(${data[0].value},${data[1].value},${data[2].value})`;
    document.querySelector("#square>span")
        .innerHTML = `rgb(${data[0].value},${data[1].value},${data[2].value})`;
    document.querySelector("#square>span")
        .style.color = `rgb(${255 - data[0].value},${255 - data[1].value},${255 - data[2].value})`;
}


