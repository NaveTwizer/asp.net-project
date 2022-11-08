// Input elements
const usernameElement = document.getElementById('username');
const passwordElement = document.getElementById('pswd');

// Error elements
const usernameError = document.getElementById('username-error-div');
const passwordError = document.getElementById('password-error-div');


function onSubmit() {
    return (isValidUsername() && isValidPassword());
}
const isValidUsername = () => {
    usernameError.innerHTML = "";
    const username = usernameElement.value;
    if (username === "") {
        usernameError.innerHTML = "הזן את שמך";
        return false;
    }
    if (usrname.length < 6) {
        usernameError.innerHTML = "שם משתמש קצר מידי";
        return false;
    }
    return true;
}
const isValidPassword = () => {
    passwordError.innerHTML = "";
    const pswd = passwordElement.value;
    if (pswd === "") {
        passwordError.innerHTML = "הזן סיסמה";
        return false;
    }
    if (pswd.length < 7) {
        passwordError.innerHTML = "סיסמה קצרה מידי";
        return false;
    }
    var matchedCase = new Array();
    matchedCase.push("[$@$!%*#?&]"); // Special Characters
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



// Show password button
const showPasswordButton = document.getElementById('show-password');
showPasswordButton.addEventListener('input', () => {
    if (passwordElement.type === 'password') {
        passwordElement.type = 'text'
    } else {
        passwordElement.type = 'password'
    }
})