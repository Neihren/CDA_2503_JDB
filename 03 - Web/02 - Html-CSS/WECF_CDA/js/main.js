const credits = document.getElementById('credits');
const validate = document.getElementById('validate');
const username = document.getElementById('username');
const result = document.getElementById('result');
const password1 = document.getElementById('password1');
const password2 = document.getElementById('password2');
credits.textContent = "Jessy DE BRITO";


function mafonction(event) {
    const formUsername = username.value.trim();
    const formPassword1 = password1.value.trim();
    const formPassword2 = password2.value.trim();
    if (formUsername.length < 3) {
        return("Le nom d'utilisateur est trop court (3 caractères minimum)");
    }
    else if (formPassword1.length < 12) {
        return("Le mot de passe est trop court (12 caractères minimum)");
    }
    else if (formPassword1 !== formPassword2) {
        return("Les mots de passe ne correspondent pas");
    }
    else {
        const userNew = {
            username: formUsername,
            password: formPassword1
        }
        console.log(userNew);
        document.body.style.backgroundColor = "darkgreen";
        return("Le formulaire est valide !");
    }
}

function display(event) {
    event.preventDefault();
    result.textContent = mafonction(event);

}

validate.addEventListener("click", display); // aaaaaaaaaaaa