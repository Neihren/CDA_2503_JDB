const myForm = document.getElementById("myForm");
const myName = document.getElementById("myName");
const myBirthDate = document.getElementById("myBirthDate");
const myPhone = document.getElementById("myPhone");
const myPassword1 = document.getElementById("myPassword1");
const myPassword2 = document.getElementById("myPassword2");

myForm.addEventListener("submit", function (event) {
  event.preventDefault();

  // controles de saisies
  const isNameValid = validateName(myName.value);
  const isDateValid = validateBirthDate(myBirthDate.value);
  const isPhoneValid = validatePhoneNumber(myPhone.value);
  console.log(isPhoneValid);
  if (isNameValid && isDateValid && isPhoneValid) {
    alert("Formulaire valide !");
  } else {
    alert("Erreur: Vérifier votre saisie");
  }
});

/**
 * Valide un nom
 * 3 caractères minimum, uniquement des lettres _name
 * @param {string} _name le nom à valider
 * @returns {Boolean} VRAI si le nom est valide, FAUX sinon
 */
function validateName(_name) {
  let regexName = /^[A-Za-z]{3,}$/;
  _name = _name.trim();

  /* if(regexName.test(_name)) {
        return true;
    } else {
        return false;
    }*/

  return regexName.test(_name);
}

/**
 * Contrôle la validité d'une date
 * @param {String} _birthDate la date à vérifier
 * @returns {Boolean} Vrai si le numéro est valide, faux sinon
 */
function validateBirthDate(_birthDate) {
  console.log(_birthDate);
  try {
    const dateTest = new Date(_birthDate);
    console.log(dateTest);

    if (isNaN(dateTest)) {
      throw new Error();
    }
    return true;
  } catch (error) {
    alert("Date non valide");
    return false;
  }
}

/**
 * Valide un numéro de téléphone
 * 0607080910
 * +33607080910
 * @param {*} _phoneNumber
 * @returns
 */
function validatePhoneNumber(_phoneNumber) {
  const regexPhone = /(?=^\+)(^\+33[1-7|9]\d{8}$)|(^[0][1-7|9]\d{8}$)/;
  const regexNoSpacesNoDots = /\.\s/g;
  _phoneNumber = _phoneNumber.trim();
  _phoneNumber = _phoneNumber.replaceAll(regexNoSpacesNoDots, '');
  return regexPhone.test(_phoneNumber);
}

/**
 * Valider que les 2 mots de passe sont identiques
 * ET
 * longueur de 12 caractères minimum
 * au moins 1 majuscule
 * au moins 1 minuscule
 * au moins 1 chiffre
 * @param {*} _password1
 * @param {*} _password2
 * @returns
 */
function validatePassword(_password1, _password2) {
  return true;
}
