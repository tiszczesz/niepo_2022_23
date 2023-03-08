document.querySelector("#gener").disabled = true;
document.querySelector("#tekst").addEventListener("input", (event) => {
    console.log("input");
    document.querySelector("#gener")
        .disabled = event.target.value.trim().length < 3
});