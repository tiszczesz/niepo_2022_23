class NWD {
    constructor(a, b) {
        this.a = a < 0 ? -a : a;
        this.b = b < 0 ? -b : b;
    }
    info() {
        console.log(this);
        return `<div>a = ${this.a} b = ${this.b}</div>`;
    }
}

const nwd1 = new NWD(34, 78);
const nwd2 = new NWD(-34, 5);
const div1 = document.createElement("div");
div1.innerHTML = nwd1.info();
document.body.appendChild(div1);
console.log(this);
//console.log(nwd2);