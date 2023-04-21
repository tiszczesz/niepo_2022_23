class PrimalGenerator{
    constructor(limit=20){
        this.limit = limit;
    }
    isPrimal(numberToCheck){
        if(numberToCheck<2) return false;
        for(let i = 2; i * i <= numberToCheck;i++){
            if(numberToCheck % i == 0) return false;
        }
        return true;
    }
    GetPrimalList(){
        const primals = [];
        let n = 2;
        while(primals.length<this.limit){
            if(this.isPrimal(n)){
                primals.push(n)
            }
            n++;
        }
        return primals;
    }
}

const generator = new PrimalGenerator(30);
console.log(generator);
console.log(generator.isPrimal(25));
console.log(generator.GetPrimalList());
