function UpdateTime() {
   document.querySelector(".time").innerHTML = new Date().toLocaleTimeString();
}
setInterval(UpdateTime, 1000);
UpdateTime();
const days = ["niedziela", "poniedziałek", "wtorek", "środa", "czwartek",
   "piątek", "sobota"];
const months = ["styczeń", "luty", "marzec", "kwiecień", "maj", "czerwiec",
   "lipiec", "sierpień", "wrzesień", "październik", "listopad", "grudzień"];

function UpdateDate(){
   const currentDate = new Date('2021-09-12');
   document.querySelector(".year").innerHTML = currentDate.getFullYear();
   document.querySelector(".month").innerHTML = months[currentDate.getMonth()];
   document.querySelector(".date").innerHTML = currentDate.getDate();
   const currentDay = currentDate.getDay();
   document.querySelector(".day").innerHTML = days[currentDay];
   document.querySelector(".day").style.color = "red";
}

UpdateDate();