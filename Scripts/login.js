﻿// Input elements
const usernameElement = document.getElementById('username');
const passwordElement = document.getElementById('pswd');

// Error elements
const usernameError = document.getElementById('username-error-div');
const passwordError = document.getElementById('password-error-div');
const usernameErrorSpan = document.getElementById('username-error-span');
const passwordErrorSpan = document.getElementById('password-error-span');


function onSubmit() {
    var b1 = isValidUsername();
    var b2 = isValidPassword();
    return b1 && b2;
}

function isValidUsername() {
    usernameError.innerText = "";
    usernameErrorSpan.style.display = "none";
    let username = usernameElement.value;
    if (username === null || username === "") {
        usernameError.innerText = "הכנס שם משתמש";
        usernameErrorSpan.style.display = "inline";
        return false;
    }
    return true;
}
function isValidPassword() {
    passwordError.innerText = "";
    passwordErrorSpan.style.display = "none";
    let pw = passwordElement.value;
    if (pw === "" || pw === null) {
        passwordError.innerText = "הכנס סיסמה";
        passwordErrorSpan.style.display = "inline";
        return false;
    }
    return true;
}