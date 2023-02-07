const mailInput = document.getElementById('mail');
const mailError = document.getElementById("ContentPlaceHolder1_feedback");

const isValid = () => {
    mailError.innerText = "";
    return isValidMail();
}
const isValidMail = () => {
    let mail = mailInput.value;
    if (!mail) {
        mailError.innerText = "הכנס כתובת מייל";
        return false;
    }
    if (!mail.includes('@')) {
        mailError.innerText = "על המייל להכיל את הסימן @";
        return false;
    }
    return true;
}