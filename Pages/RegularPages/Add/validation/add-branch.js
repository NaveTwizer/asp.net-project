// Input elements
const branchCode = document.getElementById("branchCode");
const branchName = document.getElementById("branchName");
const branchAddress = document.getElementById("branchAddress");
const branchPhone = document.getElementById("branchPhone");

// Error elements
const branchCodeError = document.getElementById("branchCodeError");
const branchNameError = document.getElementById("branchNameError");
const branchAddressError = document.getElementById("branchAddressError");
const branchPhoneError = document.getElementById("branchPhoneError");


function isValid() {
    return isValidBranchCode() && isValidName() && isValidAddress() && isValidPhone();
}
function isValidBranchCode() {
    branchCodeError.innerHTML = "";
    let code = branchCode.value;
    if (code === null || code === "") {
        branchCodeError.innerHTML = "הכנס קוד סניף";
        return false;
    }
    return true;
}
function isValidName() {
    branchNameError.innerHTML = "";
    let name = branchName.value;
    if (name === null || name === "") {
        branchNameError.innerHTML = "הכנס שם סניף";
        return false;
    }
    return true;
}
function isValidAddress() {
    branchAddressError.innerHTML = "";
    let address = branchAddress.value;

    if (address === null || address === "") {
        branchAddressError.innerHTML = "הכנס כתובת סניף";
        return false;
    }
    return true;
}
function isValidPhone() {
    branchPhoneError.innerHTML = "";
    let phone = branchPhone.value;
    if (phone === null || phone === "") {
        branchPhoneError.innerHTML = "הכנס טלפון סניף";
        return false;
    }
    return true;
}