//22-3
const greetings = 'Hellow , I am Rifat,  how are you ?'


function reverseString(text) {
    let reverse = "";
    for (const letter of text) {
        reverse = letter + reverse;
    }
    console.log(reverse);
}
const reversed = reverseString(greetings);




//
// program to reverse a string

function reverseString(str) {

    // empty string
    let newString = "";
    for (let i = str.length - 1; i >= 0; i--) {
        newString += str[i];
    }
    return newString;
}

// take input from the user
// const string = 'ACSASDC';
const prompt = require("prompt-sync")();
var string = prompt('Enter a string: ');

const result = reverseString(string);
console.log(result);