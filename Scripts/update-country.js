// Input elements
const countryName = document.getElementById('countryName');
const branchesNum = document.getElementById('branchesNum');


// Error elements
const countryNameError = document.getElementById('countryNameError');
const branchesNumError = document.getElementById('branchesNumError');



function isValid() {
    let b1 = isValidCountry();
    let b2 = isValidBranchesNum();
    return b1 && b2;
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

function isValidBranchesNum() {
    branchesNumError.innerText = "";
    let num = branchesNum.value;
    if (num === null || num === "") {
        branchesNumError.innerText = "הכנס מספר סניפים";
        return false;
    }
    num = parseInt(num);
    if (isNaN(num)) {
        branchesNumError.innerText = "הכנס מספר תקין";
        return false;
    }
    return true;
}
