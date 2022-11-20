// Input elements

const manufactorName = document.getElementById("productorName");
const countryName = document.getElementById("productorCountry");

// error elements

const manufactorNameError = document.getElementById("productorNameError");
const countryNameError = document.getElementById("productorCountryError");


function isValid() {
    let b1 = isValidName();
    let b2 = isValidCountry();
    return b1 && b2;
}
function isValidName() {
    manufactorNameError.innerText = "";
    let name = manufactorName.value;

    if (name === "" || name === null) {
        manufactorNameError.innerText = "הכנס שם יצרן";
        return false;
    }
    return true;
}
function isValidCountry() {
    countryNameError.innerText = "";
    let country = countryName.value;

    if (country === "" || country === null) {
        countryNameError.innerText = "הכנס שם מדינה";
        return false;
    }
    return true;
}