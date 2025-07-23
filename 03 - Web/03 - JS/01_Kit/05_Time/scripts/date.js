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

function displayDateTime() {
  now = new Date(Date.now());
  curDate.value = `${now.getFullYear()}-${("0" + (now.getMonth() + 1)).slice(
    -2
  )}-${("0" + now.getDate()).slice(-2)}`;
  curTime.value = `${("0" + now.getHours()).slice(-2)}:${(
    "0" + now.getMinutes()
  ).slice(-2)}`;
  dateTime.style.display = "block";
  spanDate.innerText = now.toLocaleDateString();
  spanHour.innerText = now.toLocaleTimeString();
  dateTimeDisplay.style.display = "block";
}

function calculateInterval() {
    const userDateTime = new Date(Date.parse(userInput.value));
    const nbDays = Math.floor((now - userDateTime) / 1000 / 60 / 60 / 24 );
    spanNBDays.innerText = nbDays;
    spanInterval.innerText = userDateTime.toLocaleDateString("fr-FR");
    spanInterval.innerText += ` à ${userDateTime.toLocaleTimeString("fr-FR")}` 
    displayInterval.style.display = "block"
}

btnDisplayDate.addEventListener("click", displayDateTime);
btnCalculate.addEventListener("click", calculateInterval);
