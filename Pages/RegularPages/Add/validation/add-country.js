// Input elements

const countryName = document.getElementById("countryName");
const countryNum = document.getElementById("countryName");

// Error elements
const countryNameError = document.getElementById("countryNameError");
const countryNumError = document.getElementById("countryNumError");


const feedbackElement = document.getElementById("feedback");

function isValid() {
    countryNumError.innerText = "";
    countryNameError.innerText = "";
    return isValidName() && isValidNum();
}
function isValidName() {
    countryNameError.innerText = "";
    let name = countryName.value;
    if (name === null || name === "") {
        countryNameError.innerText = "הכנס שם מדינה";
        return false;
    }
    return true;
}
function isValidNum() {
    countryNumError.innerText = "";
    var num = parseInt(countryNum.value, 10);
    if (num == "" || num === null) {
        countryNumError.innerText = "הכנס מספר סניפים";
        return false;
    }
    return true;
}