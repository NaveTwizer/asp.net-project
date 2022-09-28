const username = document.getElementById('username');
const password = document.getElementById('pswd');
const name = document.getElementById('name');
const lastname = document.getElementById('lastname');
const address = document.getElementById('address');
//const name = document.getElementsByName('gender');
const email = document.getElementById('email');
const birthday = document.getElementById('birthday');
const form = document.getElementById('form1');



const usernameError = document.getElementById('username-error');
const passwordError = document.getElementById("password-error");
const nameError = document.getElementById('name-error');


function isValid() {
    return true;
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
    let strength = 0;
    if (pswd.match(/[a-z]+/)) {
        strength += 1;
    }
    if (pswd.match(/[A-Z]+/)) {
        strength += 1;
    }
    if (pswd.match(/[0-9]+/)) {
        strength += 1;
    }
    if (pswd.match(/[$@#&amp;!_-]+/)) {
        strength += 1;
    }
    if (strength < 4) {
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
}