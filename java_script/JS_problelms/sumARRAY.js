//21-4

const number = [2, 3, 4, 45, 6, 7, 7, 8, 9, 11, 21];
let sum = 0;
for (let i = 0; i < number.length; i++) {
    const indexelement = number[i];
    // console.log(i);
    // console.log(indexelement);
    sum = sum + indexelement;
}
console.log(sum);

function arrayTotal(number1) {
    let sum = 0;
    for (let i = 0; i < number1.length; i++) {
        const element = number1[i];
        sum = sum +element;
        // return sum;
    }
    return sum;
}
const totalarray = arrayTotal([10, 20, 30])
console.log(totalarray);