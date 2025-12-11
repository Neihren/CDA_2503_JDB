const tableDiv = document.getElementById("card-table");

function insertTitleCell(row, value) {
  const myCell = document.createElement("th");
  myCell.textContent = value;
  myCell.setAttribute("class", "titre");
  row.appendChild(myCell);
}

function afficherCarte(tabcartes) {
  const myTable = document.querySelector("#jeu");
  const myTHead = myTable.createTHead();
  const myTitleRow = myTHead.insertRow();
  for (const key in tabcartes[0]) {
    insertTitleCell(myTitleRow, key);
  }
  const myTBody = myTable.createTBody();
  for (let i = 0; i < tabcartes.length; i++) {
    const myCurrRow = myTBody.insertRow();
    if (i == 0) {
      for (const key in tabcartes[i]) {
        const myCurrCell = myCurrRow.insertCell();
        myCurrCell.textContent = tabcartes[i][key];
      }
    } else {
      const valeurs = Object.values(tabcartes[i]);
      let isLevel = 0;
      for (let j = 0; j < valeurs.length; j++) {
        if (j == 2 && isLevel == 0) {
          const myCurrCell = myCurrRow.insertCell();
          myCurrCell.textContent = "";
          j--;
          isLevel = 1;
        } else {
          const myCurrCell = myCurrRow.insertCell();
          myCurrCell.textContent = valeurs[j];
          isLevel = 0;
        }
      }
    }
  }
}

fetch("https://arfp.github.io/tp/web/javascript/03-cardgame/cardgame.json")
  .then((response) => response.json())
  .then((response) => {
    afficherCarte(response);

    let mostPlayed = response[0];
    let bestRatioCard = response[0];
    let bestRatio = 0;
    response.forEach(element => {
      if (element.played > mostPlayed.played) {
        mostPlayed = element;
      }
      
      const ratio = element.victory / element.defeat;
      if (ratio > bestRatio) {
        bestRatio = ratio;
        bestRatioCard = element;
      }
    });



    const display = document.createElement("div")
    display.innerHTML = `<p> Carte ayant le plus de parties jouées : ${mostPlayed.name}, nombre victoires : ${mostPlayed.victory}</p>
                          <p> Carte ayant le meilleur ratio V/D : ${bestRatioCard.name}, nombre parties : ${bestRatioCard.played}, nombre victoires : ${bestRatioCard.victory}</p>`
    tableDiv.appendChild(display);
  });
