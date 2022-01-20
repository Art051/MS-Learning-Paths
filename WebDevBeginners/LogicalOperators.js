// assignments

let isHoliday = true;
let isMember = true;
let hasDiscount = isHoliday || isMember;

// if-else
let currentMoney = 800;
let laptopPrice = 1000;
let laptopDiscountPrice = laptopPrice - (laptopPrice * .20) //Laptop price at 20 percent off

if (currentMoney >= laptopPrice || currentMoney >= laptopDiscountPrice) {
    //Condition was true. Code in this block will run.
    console.log("Getting a new laptop!");
}
else {
    //Condition was true. Code in this block will run.
    console.log("Can't afford a new laptop, yet!");
}


// negotiation

if (!condition) {
    // runs if condition is false
} else {
    // runs if condition is true
}


// ternary

let firstNumber = 20;
let secondNumber = 10
let biggestNumber = firstNumber > secondNumber ? firstNumber : secondNumber;