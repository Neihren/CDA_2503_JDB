// let myHeading = document.querySelector("h1");
// myHeading.textContent = "Bonjour, monde !";

// let myVariable = "bob";
// myVariable = "Etienne";

// document.querySelector("html").addEventListener("click", function () {
//     alert("Aïe, arrêtez de cliquer !!");
// });
localStorage.clear();

let myImage = document.querySelector("img");

myImage.addEventListener("click", function () {
    let mySrc = myImage.getAttribute("src");
    if (mySrc === "./images/firefox-icon.png") {
        myImage.setAttribute("src", "./images/firefox2.png");
    } else {
        myImage.setAttribute("src", "./images/firefox-icon.png")
    }
});

let myButton = document.querySelector("button");
let myHeading = document.querySelector("h1");

function setUserName() {
    let myName = prompt("Veuillez saisir votre nom.");
    localStorage.setItem("nom", myName);
    myHeading.textContent = "Mozilla est cool, " + myName;
}

if (!localStorage.getItem("nom")) {
    setUserName();
} else {
    let storedName = localStorage.getItem("nom");
    myHeading.textContent = "Mozilla est cool, " + storedName;
}

myButton.addEventListener("click", function () {
    setUserName();
});