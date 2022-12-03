//20-6
//3!=3x2x1
// find 7 
let factorail = 1;
for (var  i = 1; i <= 7; i++) {
    //  console.log(factorail)
    factorail = factorail * i;
}
 console.log(factorail);


//
function getfactorialorial(number) {
    let factorial = 1;//0 value dela 0 hoe jabe
    for (let i = 1; i < number ; i++) {
        factorial = factorial * i ;
    }
    return factorial;
}
var factorial = getfactorialorial(7); //frsitfactorial
console.log('Factorial of 7 is', factorial);
var factorial = getfactorialorial(9);
//secoundfactorial
console.log('Factorial of 9 is', factorial);