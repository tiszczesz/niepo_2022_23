// function getValueFromSelect(select){
//     return select.value;
// }
const sel = document.querySelector("#choice");


// const resultChoice = getValueFromSelect(sel);
// console.log(resultChoice);

// sel.addEventListener("change", (event) => {
//     console.log(event.target.value);
// });

document.querySelector("#run").addEventListener("click", () => {
    if (Validation(document.querySelector("#n"))) {
        const choice = sel.value;
        const n = parseInt(document.querySelector("#n").value)
        switch (choice) {
            case "rek":
                    document.querySelector(".result")
                    .innerHTML = `Rekurencyjnie: ${n}! = ${SilniaRek(n)}`;
                break;
                case "iter":
                    document.querySelector(".result")
                    .innerHTML = `Iteracyjnie: ${n}! = ${SilniaIter(n)}`;
                break;
            default:
                document.querySelector(".result")
                .innerHTML = `Nie udało się obliczyć!!`;
                break;
        }
    }
    console.log(sel.value);
    console.log(SilniaIter(4), SilniaRek(4));
});
function Validation(elem) {
    const next = elem.nextElementSibling;
    const value = parseInt(elem.value);
    if (!isNaN(value) && value > 0 && value < 30) {
        next.innerHTML = ""
        return true;
    } else {
        next.innerHTML = "Błędne dane"
        return false;
    }
}
function SilniaRek(n) {
    if (n <= 1) return 1;
    return SilniaRek(n - 1) * n;
}
function SilniaIter(n) {
    if (n <= 1) return 1;
    let result = 1;
    for (let i = 1; i <= n; i++) {
        result *= i; //result = result*i;
    }
    return result;
}