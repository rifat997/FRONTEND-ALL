a = 50;
if (a > 100 || a < 0) {
    console.log('Give a number below 100 and upper 0');
}

// else if(a<0){
//     console.log('Give a number below 100 and upper 0');
// }


else if (a <= 100 && a >= 90) {
    console.log('A+');
}
else if (a <= 84 && a >= 80) {
    console.log('B+');
}
else if (a <= 79 && a >= 75) {
    console.log('C+');
}
else if (a <= 74 && a >= 70) {
    console.log('D+');
}
else if (a <= 69 && a >= 60) {
    console.log('E+');
}
else {
    console.log('BIG F');
}

