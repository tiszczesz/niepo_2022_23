function UpdateTime(){
   document.querySelector(".time").innerHTML = new Date().toLocaleTimeString(); 
}
setInterval(UpdateTime,1000);
UpdateTime();