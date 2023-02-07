// Input elements

const codeInput = document.getElementById("code");
const code2Input = document.getElementById("code2");
const nameInput = document.getElementById("name");
const addrInput = document.getElementById("address");
const phoneInput = document.getElementById("phone");


// Error elements
const codeError = document.getElementById("codeError");
const code2Error = document.getElementById("code2Error");
const nameError = document.getElementById("nameError");
const addrError = document.getElementById("addressError");
const phoneError = document.getElementById("phoneError");

const form = document.getElementById('form1');




const isAllValid = () => {
    resetErrorMessages();
    return isCodeValid() && isNameValid() && isAddrValid() && isPhoneValid();
}
const resetErrorMessages = () => {
    document.querySelectorAll(".errors").forEach(div => div.innerText = "");
}
const isCodeValid = () => {
    let code = codeInput.value;
    let code2 = code2Input.value;
    if (!code) {
        codeError.innerText = "הכנס קוד סניף";
        return false;
    }
    if (!code2) {
        code2Error.innerText = "הכנס קוד סניף פעם שנייה";
        return false;
    }
    if (code !== code2) {
        codeError.innerText = "קוד הסניף אינו תואם";
        code2Error.innerText = "קוד הסניף אינו תואם";
        return false;
    }
    if (isNaN(code)) {
        codeError.innerText = "קוד הסניף חייב להיות מספר";
        return false;
    }
    if (isNaN(code2)) {
        code2Error.innerText = "קוד הסניף חייב להיות מספר";
        return false;
    }
    return true;
}
const isNameValid = () => {
    let name = nameInput.value;
    if (!name) {
        nameError.innerText = "הכנס שם סניף";
        return false;
    }
    return true;
}
const isPhoneValid = () => {
    let phone = phoneInput.value;
    if (!phone) {
        phoneError.innerText = "הכנס מספר טלפון";
        return false;
    }
    if (phone.length !== 9 && phone.length !== 10) {
        phoneError.innerText = "על מספר הטלפון להיות באורך 9 או 10";
        return false;
    }
    return true;
}
const isAddrValid = () => {
    let addr = addrInput.value;
    if (!addr) {
        addrError.innerText = "הכנס כתובת סניף";
        return false;
    }
    return true;
}