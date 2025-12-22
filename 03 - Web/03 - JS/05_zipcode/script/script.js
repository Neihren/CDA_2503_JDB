let tabData=[];

function fillList(_tabData) {
    tabData = _tabData;
    for (let i = 0; i < tabData.length; i++) {
        const myOption = document.createElement("option")
        myOption.value = tabData[i].codePostal;
        myOption.textContent = tabData[i].codePostal + " - " + tabData[i].nomCommune;
        document.querySelector("#zc").appendChild(myOption);
    }
}

const btnSearch = document.getElementById(listCity);
btnSearch.addEventListener("click", function () {
    const objCommune = tabData.find(obj => obj.codePosta == document.querySelector("#zipcode").value)
    const myItem = document.createElement("li");
    myItem.textContent = objCommune.nomCommune;
    document.querySelector("#listCity").appendChild(myItem);
});

fetch("https://arfp.github.io/tp/web/javascript/02-zipcodes/zipcodes.json")
  .then((response) => response.json())
  .then((data) => {
    console.log(data);
    fillList(data);
  })
  .catch(console.error()
);
