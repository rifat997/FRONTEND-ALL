var arr = [5, 7, 9, 12, 58, 34, 55, 66, 88, 99, 100, 100];

//print odd number 
for (var i = 0; i <= 12; i++) {
    if (arr[i] % 2 != 0) {
        console.log(arr[i]);
    }
}
//print even numbers 
var even = [5, 7, 9, 12, 58, 34, 55, 66, 88, 99, 100, 100];
for (var i = 0; i <= 12; i++) {
    if (even[i] % 2 == 0) {
        console.log(even[i])
    }
}


//print 1-100
for (var i = 0; i <= 100; i++) {
    if (i % 2 == 0) {
        console.log(i);
    };
}

var pnine = [5, 7, 9, 12, 58];
//print 9 and 12
for (var i = 0; i <= 5; i++) {
    if (pnine[i] % 3 == 0) {
        console.log(pnine[i])
    }
}

