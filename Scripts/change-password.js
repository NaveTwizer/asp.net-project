// Input elements
const old = document.getElementById("old");
const new1 = document.getElementById("new1");
const new2 = document.getElementById("new2");

// Error elements
const oldError = document.getElementById("old-error");
const new1Error = document.getElementById("new1-error");
const new2Error = document.getElementById("new2-error");

const resetErrorMessages = () => {
    oldError.innerText = "";
    new1Error.innerText = "";
    new2Error.innerText = "";
}
const isValid = () => {
    resetErrorMessages();
    let b1 = isValidOld();
    let b2 = isValidNew1();
    let b3 = isValidNew2();
    return (b1 && b2 && b3);
}
const isValidOld = () => {
    let pw1 = old.value;
    if (!pw1) {
        oldError.innerText = "הכנס סיסמה ישנה לצורך הזדהות";
        return false;
    }
    return true;
}
const isValidNew1 = () => {
    let pw2 = new1.value;
    if (!pw2) {
        new1Error.innerText = "הכנס סיסמה חדשה";
        return false;
    }
    return true;
}
const isValidNew2 = () => {
    let pw3 = new2.value;
    if (!pw3) {
        new2Error.innerText = "הכנס סיסמה חדשה בשנית";
        return false;
    }
    let p = new1.value;
    if (pw3 !== p) {
        new1Error.innerText = "הסיסמאות אינן תואמות";
        new2Error.innerText = "הסיסמאות אינן תואמות";
        return false;
    }
    return true;
}