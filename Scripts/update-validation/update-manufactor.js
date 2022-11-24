// Input elements

const nameInput = document.getElementById("name");
const countryInput = document.getElementById("country");

// Error elements
const nameError = document.getElementById("nameError");
const countryError = document.getElementById("countryError");


function isValid() {
    let b1 = isValidName();
    let b2 = isValidCountry();
    return b1 && b2;
}
function isValidName() {
    nameError.innerText = "";
    let name = nameInput.value;
    if (name === "" || name === null) {
        nameError.innerText = "הכנס שם יצרן";
        return false;
    }
    return true;
}
function isValidCountry() {
    countryError.innerText = "";
    let country = countryInput.value;
    if (country === "" || country === null) {
        countryError.innerText = "הכנס מדינת יצרן";
        return false;
    }
    return true;
}
