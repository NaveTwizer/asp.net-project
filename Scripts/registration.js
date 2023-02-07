// Input elements
const username = document.getElementById('username');
const password = document.getElementById('pswd');
const name = document.getElementById('name');
const lastname = document.getElementById('lastname');
const address = document.getElementById('address');
const email = document.getElementById('email');
const birthday = document.getElementById('birthday');
const form = document.getElementById('form1');
const addressElement = document.getElementById('address');
const emailElement = document.getElementById('email');



// Error elements
const usernameError = document.getElementById('UsernameError');
const passwordError = document.getElementById("password-error");
const nameError = document.getElementById('name-error');
const lastNameError = document.getElementById('lastname-error');
const addressError = document.getElementById('address-error');
const emailError = document.getElementById('EmailError');



function isValid() {
    resetErrorMessages();
    return (validUsername() && validPassword() && validName() && validLastName() && validAddress() && validEmail());
}
function validUsername() {
    usernameError.innerHTML = "";
    const usrname = username.value;
    if (usrname === "") {
        usernameError.innerHTML = "שם משתמש לא תקין";
        return false;
    }
    if (usrname.length < 6) {
        usernameError.innerHTML = "שם משתמש קצר מידי"
        return false;
    }
    return true;
}
function validPassword() {
    passwordError.innerHTML = "";
    const pswd = password.value;
    if (pswd === "") {
        passwordError.innerHTML = "הזן סיסמה";
        return false;
    }
    if (pswd.length < 7) {
        passwordError.innerHTML = "סיסמה קצרה מידי";
        return false;
    }
    var matchedCase = new Array();
    matchedCase.push("[$@$!%*#?&]"); // Special Charector
    matchedCase.push("[A-Z]");      // Uppercase Alpabates
    matchedCase.push("[0-9]");      // Numbers
    matchedCase.push("[a-z]");     // Lowercase Alphabates
    var strength = 0;
    for (var i = 0; i < matchedCase.length; i++) {
        if (new RegExp(matchedCase[i]).test(pswd)) {
            strength++;
        }
    }
    switch (strength) {
        case 0:
        case 1:
        case 2:
            passwordError.innerHTML = "סיסמה חלשה";
            return false;
    }
    return true;
}
function validName() {
    nameError.innerHTML = "";
    const nme = name.value;
    if (nme === "") {
        nameError.innerHTML = "הזן את שמך";
        return false;
    }
    if (nme.length === 1) {
        nameError.innerHTML = "שם קצר מידי.";
        return false;
    }
    return true;
}
function validLastName() {
    lastNameError.innerHTML = "";
    const lastName = lastname.value;

    if (lastName === "") {
        lastNameError.innerHTML = "הזן שם משפחה";
        return false;
    }
    return true;
}
function validAddress() {
    addressError.innerHTML = "";
    const address = addressElement.value;
    if (address === "" || address === null) {
        addressError.innerHTML = "הזן כתובת";
        return false;
    }
    return true;
}
function validEmail() {
    emailError.innerHTML = "";
    const email = emailElement.value;
    if (email === "") {
        emailError.innerHTML = "הזן מייל";
        return false;
    }
    return true;
}
const resetErrorMessages = () => {
    document.querySelectorAll('.error-td').forEach(e => {
        e.innerHTML = "";
    })
}