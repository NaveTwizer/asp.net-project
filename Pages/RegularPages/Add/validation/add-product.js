// Input elements

const productCode = document.getElementById('productCode');
const productName = document.getElementById('productName');
const depName = document.getElementById('depName');
const productorName = document.getElementById('productorName');
const providerCode = document.getElementById('providerCode');
const price = document.getElementById('price');
const amount = document.getElementById('amount');

// Error elements

const productCodeError = document.getElementById('productCodeError');
const productNameError = document.getElementById('productNameError');
const depNameError = document.getElementById('depNameError');
const productorNameError = document.getElementById('productorNameError');
const providerCodeError = document.getElementById('providerCodeError');
const productDescError = document.getElementById('productDescError');
const priceError = document.getElementById('priceError');
const amountError = document.getElementById('amountError');

function isValid() {
    return isValidCode() && isValidName() && isValidDep() && isValidProductor() && isValidProvider() && isValidPrice() && isValidAmount();
}

const isValidCode = () => {
    productCodeError.innerText = "";
    let code = productCode.value;
    if (code === null || code === "") {
        productCodeError.innerText = "הכנס קוד מוצר";
        return false;
    }
    return true;
}
const isValidName = () => {
    productNameError.innerText = "";
    let name = productName.value;
    if (name === null || name === "") {
        productNameError.innerText = "הכנס שם מוצר";
        return false;
    }
    return true;
}
const isValidDep = () => {
    depNameError.innerText = "";
    let dep = depName.value;
    if (dep === "" || dep === null) {
        depNameError.innerText = "הכנס מחלקת מוצר";
        return false;
    }
    return true;
}
const isValidProductor = () => {
    productorNameError.innerText = "";
    let productor = productorName.value;
    if (productor === "" || productor === null) {
        productorNameError.innerText = "הכנס שם יצרן";
        return false;
    }
    return true;
}
const isValidProvider = () => {
    providerCodeError.innerText = "";
    let provider = providerCode.value;
    if (provider === null || provider === "") {
        providerCodeError.innerText = "הכנס קוד ספק";
        return false;
    }
    return true;
}
const isValidPrice = () => {
    priceError.innerText = "";
    let p = price.value;
    if (p === "" || p === null) {
        priceError.innerText = "הכנס מחיר מוצר";
        return false;
    }
    return true;
}
const isValidAmount = () => {
    amountError.innerText = "";
    let amnt = amount.value;
    if (amnt === null || amnt === "") {
        amountError.innerText = "הכנס כמות מוצר";
        return false;
    }
    return true;
}