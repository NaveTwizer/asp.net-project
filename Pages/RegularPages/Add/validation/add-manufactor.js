// Input elements


const manufactorName = document.getElementById("manufactorName");
const countryName = document.getElementById("countryName");

// error elements

const manufactorNameError = document.getElementById("manufactorNameError");
const countryNameError = document.getElementById("countryNameError");


function isValid() {
    return isValidName() && isValidCountry();
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