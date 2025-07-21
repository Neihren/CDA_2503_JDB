const inputDOB = document.getElementById("inputDOB");
const btnCalculate = document.getElementById("btnCalculate");
const info = document.getElementById("info");

function calculateAge() {
  const dobTimeStamp = new Date(Date.parse(inputDOB.value));
  const dobLocalDate = dobTimeStamp.toLocaleDateString("fr-FR");
  if (dobTimeStamp <= Date.now()) {
    const age = Math.floor((Date.now() - dobTimeStamp) / 31557600000);
    info.innerHTML = `<hr>Vous êtes né le <span> ${dobLocalDate} </span> à <span>${dobTimeStamp.toLocaleTimeString(
      "fr-FR"
    )}</span>.<br><br>`;
    info.innerHTML += `Il s'est écoulé ${age} années depuis votre naissance.`;
  } else {
    info.innerHTML = "<hr>Sélectionnez une date dans le passé.";
  }
  const signeList = [
    { nom: "Verseau", date: new Date(dobTimeStamp.getFullYear() + "-01-20") },
    { nom: "Poissons", date: new Date(dobTimeStamp.getFullYear() + "-02-19") },
    { nom: "Bélier", date: new Date(dobTimeStamp.getFullYear() + "-03-21") },
    { nom: "Taureau", date: new Date(dobTimeStamp.getFullYear() + "-04-20") },
    { nom: "Gémeaux", date: new Date(dobTimeStamp.getFullYear() + "-05-21") },
    { nom: "Cancer", date: new Date(dobTimeStamp.getFullYear() + "-06-21") },
    { nom: "Lion", date: new Date(dobTimeStamp.getFullYear() + "-07-23") },
    { nom: "Vierge", date: new Date(dobTimeStamp.getFullYear() + "-08-23") },
    { nom: "Balance", date: new Date(dobTimeStamp.getFullYear() + "-09-23") },
    { nom: "Scorpion", date: new Date(dobTimeStamp.getFullYear() + "-10-23") },
    { nom: "Sagittaire", date: new Date(dobTimeStamp.getFullYear() + "-11-21") },
    { nom: "Capricorne", date: new Date(dobTimeStamp.getFullYear() + "-12-22") },
  ];

  let userSign = signeList[signeList.length - 1].nom;
  for (let i = 0; i < signeList.length; i++) {
    if (dobTimeStamp > signeList[i].date) {
      userSign = signeList[i].nom;
    }
  }

  info.innerHTML += `<hr>Votre signe astrologique est : <span>${userSign}</span>`;
}

btnCalculate.addEventListener("click", calculateAge);
