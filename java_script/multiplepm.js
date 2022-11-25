//4-19-4
//replce numbres::
function addTwo(number1, number2) {
    console.log(number1, number2)
    //console.log(number2)
}
// addTwo(21,67) directly will show 21 and 67
addTwo(21, 67)

var value1 = 49;
var value2 = 69;
addTwo(value1, value2)


//add two

function additionTwo(num1, num2) {
    console.log(num1, num2)
    var total = num1 + num2;
    return total;
}
var fst = 40;
var snd = 60;
var result = additionTwo(fst, snd);
console.log('Muy rsult is', result)

//multiplaction::

function multi(val1, val2) {
    var result = val1 * val2;
    return result;
}
var total = multi(500, 10)
console.log('Show value is ', total)

//div ::

function div(int1, int2) {
    var result = int1 / int2;
    return result;
}
var totaldiv = div(500, 10)
console.log('Show value is ', totaldiv)
