const draw_sq = document.querySelector("#draw_sq");
draw_sq.addEventListener("click", (event) => {
    const canvas = document.querySelector(".scene");
    const ctx = canvas.getContext("2d");
    console.log(ctx);
    const info = document.querySelector(".info");
    if (info.getContext) {
        console.log("jest");
    }else{
        console.log("brak");
    }
    const x = document.querySelector("#x").value;
    const y = document.querySelector("#y").value;
    ctx.beginPath();
    ctx.strokeStyle = document.querySelector("#color").value;
    ctx.arc(x,y,30,0,Math.PI*2,true);
    ctx.stroke();
   // ctx.beginPath();
   // ctx.lineWidth = "1";
    // ctx.strokeStyle = "green";
    // ctx.strokeRect(150, 120, 30, 20);
    // ctx.stroke();
    // ctx.strokeStyle = "blue";
    // ctx.arc(100,100,30,0,Math.PI/2,false);
   
    // const color = document.querySelector("#color");
    // ctx.moveTo(60,10);
    // ctx.lineTo(170,75);
    // ctx.stroke();
    // console.log(color.value);
});