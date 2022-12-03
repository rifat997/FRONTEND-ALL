//21-3
const number1 =450;
const number2= 350;
if (number1 > number2) {
    console.log ("Number 1 is bigger");
    
} else {

    console.log ("Number 2 is bigger");
} 


//with function 
const business =450;
const mins= 350;
const army =700;

if (business > mins && business > army) {
    console.log("Business is bigger ")
    
} else if (mins > business && mins > army) {
    console.log("Minister is bigger")
    
}  else {
    console.log("Army is bigger")
}
    
//Math.max use

var maxnumber =Math.max(business , mins , army)
console.log('largest number is ', maxnumber);

//another way:
let frist=300;
let secound= 250;
function firstlargest(frist,secound) {
    if (frist > secound) {
        return frist;
    } else {
        return secound;
    }
}


 const largest =firstlargest(250,500)
 console.log ("the largest number is ", largest)
    
