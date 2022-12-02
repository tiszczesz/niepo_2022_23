class Cezar {
    constructor(key, text) {
        this.key = key%26;
        this.text = text;
        this.range = 26;
    }
    isChar(character) {
        return character.toUpperCase() != character.toLowerCase()
    }
    charCode(character) {
        if(character===' ') return character;
        let result =  this.isChar(character) ? String.fromCharCode(character.charCodeAt() + this.key) : character;
        console.log(this.range);
        if(this.key>=0){
            return this.isChar(result)? result : String.fromCharCode(result.charCodeAt() - this.range)
        }else {
            return this.isChar(result)? result : String.fromCharCode(result.charCodeAt() + this.range)
        }
        
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
document.querySelector("#dekoduj").addEventListener("click", () => {
    const key = parseInt(document.querySelector("#key").value);
    const tekst = document.querySelector("#encode").value;
    const cezar = new Cezar(-key, tekst)
    console.log(cezar.stringCode());
    document.querySelector("#result").innerHTML = cezar.stringCode();
});
const toMoorse = {
    "a":"*-",
}
"---|***|--- --*|"
