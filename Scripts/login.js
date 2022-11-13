// Input elements
const usernameElement = document.getElementById('username');
const passwordElement = document.getElementById('pswd');

// Error elements
const usernameError = document.getElementById('username-error-div');
const passwordError = document.getElementById('password-error-div');


function onSubmit() {
    return isValidUsername() && isValidPassword();
}

function isValidUsername() {
    usernameError.innerText = "";
    let username = usernameElement.value;
    if (username === null || username === "") {
        usernameError.innerText = "הכנס שם משתמש";
        return false;
    }
    return true;
}
function isValidPassword() {
    let pw = passwordElement.value;
    if (pw === "" || pw === null) {
        passwordError.innerText = "הכנס סיסמה";
        return false;
    }
    return true;
}