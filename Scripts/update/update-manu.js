// Input elements

const nameInput = document.getElementById('name');
const name2Input = document.getElementById('name2');
const countryInput = document.getElementById('country');


// Error elements

const nameError = document.getElementById('nameError');
const name2Error = document.getElementById('name2Error');
const countryError = document.getElementById('countryError');



const isValid = () => {
    resetErrorMessages();
    return isValidName() && isValidName2() && isValidCountry();
}
const resetErrorMessages = () => {
    const errors = document.querySelectorAll('.errors');
    errors.forEach((elem) => {
        elem.innerText = "";
    })
}
const isValidName = () => {
    const name = nameInput.value;
    if (!name) {
        nameError.innerText = "הכנס שם יצרן";
        return false;
    }
    return true;
}
const isValidName2 = () => {
    const name2 = name2Input.value;
    if (!name2) {
        name2Error.innerText = "הכנס שם יצרן שנית";
        return false;
    }
    const name = nameInput.value;
    if (name !== name2) {
        nameError.innerText = "שם היצרן אינו תואם";
        name2Error.innerText = "שם היצרן אינו תואם";
        return false;
    }
    return true;
}
const isValidCountry = () => {
    const country = countryInput.value;
    if (!country) {
        countryError.innerText = "הכנס מדינת יצרן";
        return false;
    }
    return true;
}