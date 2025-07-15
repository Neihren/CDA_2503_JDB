const firstname = document.getElementById("firstname")
const age = document.getElementById("age")
const validate = document.getElementById("validate")
const empty = document.getElementById("empty")
const message = document.getElementById("message")

empty.addEventListener("click", function() {
    message.innerText = ""
})

validate.addEventListener("click", function() {
    if (age.value > 0 && firstname.value != "") {
        message.innerHTML = "Bonjour <span style='color: blue; font-weight: bold'>" + firstname.value + "</span>, votre âge est : <span style='color: blue; font-weight: bold'>" + age.value + "</span>."
        if (age.value > 17) {
            message.innerHTML += "<br><br>Vous êtes <span style='color: blue; font-weight: bold'>majeur</span>."
        }
        else {
            message.innerHTML += "<br><br>Vous êtes <span style='color: blue; font-weight: bold'>mineur</span>."
        }        
        message.innerHTML += "<br><br>"
        if (age.value < 64) {
            message.innerHTML += "Il vous reste <span style='color: blue; font-weight: bold'>" + (64 - age.value) + "</span> année(s) avant la retraite."
        }
        else if (age.value > 64) {
            message.innerHTML += "Vous êtes à la retraite depuis " + (age.value - 64) + " année(s)."
        }
        else {
            message.innerHTML += "Vous prenez votre retraite cette année !"
        }
    }
    else {
        message.innerText = "Compléter/corriger le formulaire"
    }
})