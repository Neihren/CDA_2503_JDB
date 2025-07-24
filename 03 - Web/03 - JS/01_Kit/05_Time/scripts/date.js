const curDate = document.getElementById("curDate");
const curTime = document.getElementById("curTime");
const btnDisplayDate = document.getElementById("btnDisplayDate");
const dateTimeDisplay = document.getElementById("dateTimeDisplay");
const dateTime = document.getElementById("dateTime");
const btnCalculate = document.getElementById("btnCalculate");
const spanDate = document.getElementById("spanDate");
const spanHour = document.getElementById("spanHour");
const displayInterval = document.getElementById("displayInterval");
const spanInterval = document.getElementById("spanInterval");
const userInput = document.getElementById("userInput");
const spanNBDays = document.getElementById("spanNBDays");
let now;

function tsToDateString(ts) {
  const date = `${ts.getFullYear()}-${("0" + (ts.getMonth() + 1)).slice(-2)}-${("0" + ts.getDate()).slice(-2)}`;
  return date;
}

function tsToTimeString(ts) {
  const time = `${("0" + now.getHours()).slice(-2)}:${("0" + now.getMinutes()).slice(-2)}`;
  return time;
}

function tsToDays(ts) {
  const days = Math.floor((now - ts) / 1000 / 60 / 60 / 24 );
  return days;
}

function tsToDaysHoursMinutesString(ts) {
  
}

function displayDateTime() {
  now = new Date(Date.now());
  curDate.value = tsToDateString(now);
  curTime.value  = tsToTimeString(now);
  dateTime.style.display = "block";
  spanDate.textContent = now.toLocaleDateString();
  spanHour.textContent = now.toLocaleTimeString();
  dateTimeDisplay.style.display = "block";
}

function displayNewInterval() {
    const userDateTime = new Date(Date.parse(userInput.value));
    spanNBDays.textContent = tsToDays(userDateTime);
    spanInterval.textContent = userDateTime.toLocaleDateString("fr-FR");
    spanInterval.textContent += ` à ${userDateTime.toLocaleTimeString("fr-FR")}` 
    displayInterval.style.display = "block"
}

btnDisplayDate.addEventListener("click", displayDateTime);
btnCalculate.addEventListener("click", displayNewInterval);
