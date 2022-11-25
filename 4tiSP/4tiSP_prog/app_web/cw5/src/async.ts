const deley3 = (t:number,v:string)=>{
    return new Promise<void> ((resolve)=>{
        setTimeout(()=>{
            console.log(v);
            resolve()
        },t)
    });
}
(async function(){
    await deley3(3000,"zadanie 1");
    await deley3(2000,"zadanie 2");
    await deley3(1000,"zadanie 3");
})()
