const nbClique = document.getElementById("nbClique")
const buttonAdd = document.getElementById("buttonAdd")
const buttonReset = document.getElementById("buttonReset")

let nb = 0
buttonAdd.addEventListener("click", function() {
    nb++
    textChange(nb)
})

buttonReset.addEventListener("click", function() {
    nb = 0
    textChange(0)
})

function textChange (nb) {
    nbClique.innerText = "vous avez cliqué : " + nb + " fois"
}