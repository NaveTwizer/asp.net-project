// Card inputs

const one = document.getElementById("one");
const two = document.getElementById("two");
const three = document.getElementById("three");
const four = document.getElementById("four");
const yearSelect = document.getElementById('YearSelect');
const monthSelect = document.getElementById('MonthSelect');
const cvv = document.getElementById('cvv');

const form = document.getElementById("form1");


one.addEventListener('input', () => {
    if (one.value.length === 4) {
        two.focus();
    }
})
two.addEventListener('input', () => {
    if (two.value.length === 4) {
        three.focus();
    }
})
three.addEventListener('input', () => {
    if (three.value.length === 4) {
        four.focus();
    }
})

const resetStyles = () => {
    one.style.border = 0;
    two.style.border = 0;
    three.style.border = 0;
    four.style.border = 0;
    yearSelect.style.border = 0;
    monthSelect.style.border = 0;
    cvv.style.border = 0;
}
form.addEventListener('submit', e => {
    resetStyles();
    e.preventDefault();
    let b1 = validateOne();
    let b2 = validateTwo();
    let b3 = validateThree();
    let b4 = validateFour();
    let b5 = validateCvv();

    if (b1 && b2 && b3 && b4 && b5) {
        form.submit();
    }
    if (!b1) {
        one.style.border = "3px solid red";
    }
    if (!b2) {
        two.style.border = "3px solid red";
    }
    if (!b3) {
        three.style.border = "3px solid red";
    }
    if (!b4) {
        four.style.border = "3px solid red";
    }
    if (!b5) {
        cvv.style.border = "3px solid red";
    }
})


const validateOne = () => one.value !== null && one.value !== "" && one.value.length === 4;
const validateTwo = () => two.value !== null && two.value !== "" && two.value.length === 4;
const validateThree = () => three.value !== null && three.value !== "" && three.value.length === 4;
const validateFour = () => four.value !== null && four.value !== "" && four.value.length === 4;
const validateCvv = () => cvv.value !== null && cvv.value !== "" && cvv.value.length === 3;