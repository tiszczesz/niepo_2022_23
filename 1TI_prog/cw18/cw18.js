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
    ctx.fillRect(25,25,30,30);
   // ctx.beginPath();
   // ctx.lineWidth = "3";
   // ctx.strokeStyle = "#4455ee";
    ctx.strokeRect(150, 120, 30, 20);
    //ctx.stroke();
    const color = document.querySelector("#color");
    console.log(color.value);
});