const buttonIncr = document.getElementById("buttonIncr");
const buttonReduc = document.getElementById("buttonReduc");
const textSize = document.getElementById("textSize");
const text = document.getElementById("text");

buttonIncr.addEventListener("click", function () {
  if (textSize.value > 47) {
    textSize.value = 16;
  } else {
    textSize.value++;
  }
  text.style.fontSize = textSize.value + "px";
});

buttonReduc.addEventListener("click", function () {
  if (textSize.value < 7) {
    textSize.value = 16;
  } else {
    textSize.value--;
  }
  text.style.fontSize = textSize.value + "px";
});

textSize.addEventListener("keypress", function(event) {
  console.log(this);
  if (event.key === "Enter") {
    if (textSize.value < 8 || textSize.value > 48) {
      textSize.value = 16;
      alert("La valeur saisie doit être comprise entre 8 et 48.")
    }
    text.style.fontSize = textSize.value + "px";
  }
});
