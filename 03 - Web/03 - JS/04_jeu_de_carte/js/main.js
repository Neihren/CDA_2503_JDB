fetch("https://arfp.github.io/tp/web/javascript/03-cardgame/cardgame.json")
.then(response => response.json())
.then(response => alert(JSON.stringify(response)))
.catch(error => alert("Erreur : " + error));