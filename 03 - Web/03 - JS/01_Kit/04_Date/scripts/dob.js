const inputDOB = document.getElementById("inputDOB");
const btnCalculate = document.getElementById("btnCalculate");
const info = document.getElementById("info");

function calculateAge() {
  console.log(inputDOB);
  const dobTimeStamp = new Date(Date.parse(inputDOB.value));
  const dobLocalDate = dobTimeStamp.toLocaleDateString("fr-FR");
  if (dobTimeStamp <= Date.now()) {
    const age = Math.floor((Date.now() - dobTimeStamp) / 31557600000);
    info.innerHTML =
      "<hr>Vous êtes né le <span>" +
      dobLocalDate +
      "</span> à <span>" +
      dobTimeStamp.toLocaleTimeString("fr-FR") +
      "</span>.";
    info.innerHTML += "<br><br>";
    info.innerHTML +=
      "Il s'est écoulé " + age + " années depuis votre naissance.";
  } else {
    info.innerHTML = "<hr>Sélectionnez une date dans le passé.";
  }
  const signes = [
    { nom : "Verseau", date : new Date(this.dobTimeStamp.getFullYear() + '-01-20')},
    { nom : "Poissons", date : new Date(this.dobTimeStamp.getFullYear() + '-02-19')},
    { nom : "Bélier", date : new Date(this.dobTimeStamp.getFullYear() + '-03-21')},
    { nom : "Taureau", date : new Date(this.dobTimeStamp.getFullYear() + '-04-20')},
    { nom : "Gémeaux", date : new Date(this.dobTimeStamp.getFullYear() + '-05-21')},
    { nom : "Cancer", date : new Date(this.dobTimeStamp.getFullYear() + '-06-21')},
    { nom : "Lion", date : new Date(this.dobTimeStamp.getFullYear() + '-07-23')},
    { nom : "Vierge", date : new Date(this.dobTimeStamp.getFullYear() + '-08-23')},
    { nom : "Balance", date : new Date(this.dobTimeStamp.getFullYear() + '-09-23')},
    { nom : "Scorpion", date : new Date(this.dobTimeStamp.getFullYear() + '-01-20')},
    { nom : "Sagittaire", date : new Date(this.dobTimeStamp.getFullYear() + '-01-20')},
    { nom : "Captricorne", date : new Date(this.dobTimeStamp.getFullYear() + '-01-20')},
  ]
  con
}
//20b 10a 24o
//15b 7a 15o
btnCalculate.addEventListener("click", calculateAge);
