class Cezar {
    constructor(key, text) {
        this.key = key;
        this.text = text;
    }
    isChar(character) {
        return character.toUpperCase() != character.toLowerCase()
    }
    charCode(character) {
        return this.isChar(character) ? String.fromCharCode(character.charCodeAt() + this.key) : character;
    }
    stringCode() {
        let result = "";
        for (let i = 0; i < this.text.length; i++) {
            result += this.charCode(this.text[i])
        }
        return result;
    }
}
document.querySelector("#koduj").addEventListener("click", () => {
    const key = parseInt(document.querySelector("#key").value);
    const tekst = document.querySelector("#encode").value;
    const cezar = new Cezar(key, tekst)
    console.log(cezar.stringCode());
    document.querySelector("#result").innerHTML = cezar.stringCode();
});

const toMoorse = {
    "a":"*-",
}
"---|***|--- --*|"
