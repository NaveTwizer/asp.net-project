




const PlusButtons = document.querySelectorAll('.plus');
const MinusButtons = document.querySelectorAll('.minus');



PlusButtons.forEach(button => {
    button.addEventListener("click", () => {
        let input = document.getElementById(button.getAttribute("data-input-id"));
        let val = input.value;
        val = isNaN(val) ? 0 : val;
        val++;
        input.value = val;
    })
})
MinusButtons.forEach(button => {
    button.addEventListener("click", () => {
        let input = document.getElementById(button.getAttribute("data-input-id"));
        let val = input.value;
        val = isNaN(val) ? 0 : val;
        if (val != 0) {
            val--;
        }
        input.value = val;
    })
})