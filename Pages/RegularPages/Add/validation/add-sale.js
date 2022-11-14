// input elements

const saleCode = document.getElementById('saleCode');
const saleDate = document.getElementById('saleDate');
const branchCode = document.getElementById('branchCode');
const workerId = document.getElementById('workerId');

// error elements

const saleCodeError = document.getElementById('saleCodeError');
const saleDateError = document.getElementById('saleDateError');
const branchCodeError = document.getElementById('branchCodeError');
const workerIdError = document.getElementById('workerIdError');


function isValid() {
    let b1 = isValidSaleCode();
    let b2 = isValidDate();
    let b3 = isValidBranchCode();
    let b4 = isValidWorkerId();
    return b4 && b1 && b2 && b3;
}
function isValidSaleCode() {
    saleCodeError.innerText = "";
    let c = saleCode.value;
    if (c === null || c === "") {
        saleCodeError.innerText = "הכנס קוד מכירה";
        return false;
    }
    return true;
}
function isValidDate() {
    saleDateError.innerText = "";
    let date = saleDate.value;

    if (date === "" || date === null) {
        saleDateError.innerText = "הזן תאריך תקין";
        return false;
    }
    return true;
}
function isValidBranchCode() {
    branchCodeError.innerText = "";
    let bc = branchCode.value;
    if (bc === "" || bc === null) {
        branchCodeError.innerText = "הכנס קוד סניף";
        return false;
    }
}
function isValidWorkerId() {
    workerIdError.innerText = "";
    let id = workerId.value;
    if (id === "" || id === null) {
        workerIdError.innerText = "הכנס תז עובד";
        return false;
    }
    if (id.length != 9) {
        workerIdError.innerText = "הכנס תז תקין כולל ספרת ביקורת";
        return false;
    }
    return true;
}