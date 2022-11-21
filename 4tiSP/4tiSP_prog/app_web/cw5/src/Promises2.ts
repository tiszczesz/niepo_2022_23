const Delay2 = (t: number, v: string) => {
  return new Promise<void>((res) => {
    setTimeout(() => {
      console.log(v);
      res();
    }, t);
  });
};

Delay2(3000,"Zadanie 1").then((res)=>{
    //console.log(res)
    return Delay2(2000,"zadanie 2")  ;
}).then(()=>{
    return Delay2(1000,"Zadanie 3")
}).then(()=>{
    return Delay2(200,"Zadanie 4")
})
.then(()=>{
    console.log("koniec zadań")
});
