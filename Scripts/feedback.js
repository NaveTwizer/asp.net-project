const opinionError = document.getElementById('opinionError');


const inputs = document.querySelectorAll('.inputs');


inputs.forEach(inp => {
    inp.addEventListener('input', e => {
        var value = parseInt(e.target.value);
        if (value < 3) {
            inp.style.backgroundColor = "red";
        }
        if (value > 3) {
            inp.style.backgroundColor = "green";
        }
        if (value === 3) {
            inp.style.backgroundColor = "yellow";
        }
    })
})

const IsValid = () => {
    let flag = true;
    inputs.forEach(inp => {
        inp.style.backgroundColor = "transparent";
        if (!inp.value) {
            document.getElementById(inp.getAttribute('id') + 'Error').innerText = "על הערך לא להיות ריק";
            flag = false;
        }
        var val = parseInt(inp.value);
        if (isNaN(val)) {
            document.getElementById(inp.getAttribute('id') + 'Error').innerText = "על הערך להיות מספר";
            return false;
        }
        if (val > 5 || val < 1) {
            document.getElementById(inp.getAttribute('id') + 'Error').innerText = "על הערך להיות בין אחד לחמש";
            flag = false;
        }
    })
    return flag;
}