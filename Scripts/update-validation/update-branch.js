// Input elements

const branchName = document.getElementById('branchName');
const branchCode = document.getElementById('branchCode');
const branchAddress = document.getElementById('branchAddress');
const branchPhone = document.getElementById('branchPhone');

// Error elements

const branchNameError = document.getElementById('branchNameError');
const branchCodeError = document.getElementById('branchCodeError');
const branchAddressError = document.getElementById('branchAddressError');
const branchPhoneError = document.getElementById('branchPhoneError');


const isValid = () => {
    let b1 = isValidName();
    let b2 = isValidCode();
    let b3 = isValidAddress();
    let b4 = isValidPhone();
    return b1 && b2 && b3 && b4;
}

const isValidName = () => {
    branchNameError.innerText = "";
    let name = branchName.value;
    if (name === "" || name === null) {
        branchNameError.innerText = "הכנס שם סניף";
        return false;
    }
    return true;
}
const isValidCode = () => {
    branchCodeError.innerText = "";
    let code = branchCode.value;
    if (code === "" || code === null) {
        branchCodeError.innerText = "הכנס קוד סניף";
        return false;
    }
    return true;
}
const isValidAddress = () => {
    branchAddressError.innerText = "";
    let addr = branchAddress.value;
    if (addr === "" || addr === null) {
        branchAddressError.innerText = "הכנס כתובת סניף";
        return false;
    }
    return true;
}
const isValidPhone = () => {
    branchPhoneError.innerText = "";
    let phone = branchPhone.value;
    if (phone === "" || phone === null) {
        branchPhoneError.innerText = "הכנס טלפון סניף";
        return false;
    }
    if (phone.length < 7) {
        branchPhoneError.innerText = "מספר טלפון קצר מידי";
        return false;
    }
    let numbers = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"];
    for (var i = 0; i < phone.length; i++) {
        if (!numbers.includes(phone.charAt(i))) {
            branchPhoneError.innerText = "על המספר להכיל ספרות בלבד";
            return false;
        }
    }
    return true;
}