// Input elements

const providerCode = document.getElementById('providerCode');
const providerName = document.getElementById('providerName');
const providerAddress = document.getElementById('providerAddress');
const providerPhone = document.getElementById('providerPhone');
const providerMail = document.getElementById('providerMail');

// Error elements
const providerCodeError = document.getElementById('providerCodeError');
const providerNameError = document.getElementById('providerNameError');
const providerAddressError = document.getElementById('providerAddressError');
const providerPhoneError = document.getElementById('providerPhoneError');
const providerMailError = document.getElementById('providerMailError');


function isValid() {
    let b1 = isValidCode();
    let b2 = isValidName();
    let b3 = isValidAddress();
    let b4 = isValidPhone();
    let b5 = isValidMail();
    return b1 && b2 && b3 && b4 && b5;
}

function isValidCode() {
    providerCodeError.innerText = "";
    let code = providerCode.value;

    if (code === "" || code === null) {
        providerCodeError.innerText = "הכנס קוד ספק";
        return false;
    }
    return true;
}
function isValidName() {
    providerNameError.innerText = "";
    let name = providerName.value;

    if (name === null || name === "") {
        providerNameError.innerText = "הכנס שם ספק"
        return false;
    }
    return true;
}
function isValidAddress() {
    providerAddressError.innerText = "";
    let addr = providerAddress.value;

    if (addr === "" || addr === null) {
        providerAddressError.innerText = "הכנס כתובת ספק";
        return false;
    }
    return true;
}
function isValidPhone() {
    providerPhoneError.innerText = "";
    let phone = providerPhone.value;

    if (phone === null || phone === "") {
        providerPhoneError.innerText = "הכנס טלפון ספק";
        return false;
    }
    return true;
}
function isValidMail() {
    providerMailError.innerText = "";
    let mail = providerMail.value;

    if (mail === "" || mail === null) {
        providerMailError.innerText = "הכנס מייל ספק";
        return false;
    }
    return true;
}