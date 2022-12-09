


let MyFun2 = function(a){
    console.log(arguments);
    return a+20;
}

console.log(MyFun2(100,78,"sdfsdfs"));

const myFun3 = (a,b)=>{
    console.log(this);
    return a+b;
};
MyFun1("ala ma kota");
function MyFun1(arg1, arg2){
    console.log(arg1,arg2);
    console.log(arguments);
    myFun3(2,6)
    console.log(this);
}
console.log(myFun3("ala","bela"));