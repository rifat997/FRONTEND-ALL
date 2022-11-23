// var arr = [5, 7, 9, 12, 58, 34, 55, 66, 88, 99, 100, 100];

//print odd number 
// for (var i = 0; i <= 12; i++) {
//     if (arr[i] % 2 != 0) {
//         console.log(arr[i]);
//     }
// }
//print even numbers 
// var even = [5, 7, 9, 12, 58, 34, 55, 66, 88, 99, 100, 100];
// for (var i = 0; i <= 12; i++) {
//     if (even[i] % 2 == 0) {
//         console.log(even[i])
//     }
// }


//print 1-100
// for (var i = 0; i <= 100; i++) {
//     if (i % 2 == 0) {
//         console.log(i);
//     };
// }

// var pnine = [5, 7, 9, 12, 58];
//print 9 and 12
// for (var i = 0; i <= 5; i++) {
//     if (pnine[i] % 3 == 0) {
//         console.log(pnine[i])
//     }
// }


//for loop recap::

//even odd::
//simmple print by for loop 
// for (i = 0; i < 10; i++) {
//     console.log("i")//strring print 
//     console.log(i)//intrger number print 
// }


//even number without comditon :: 
// for (i = 0; i <= 10; i += 2) {
//     console.log(i)

// }

//odd number without comditon :: 
// for (i = 1; i <= 10; i += 2) {
//     console.log(i)

// }




//print all array element ::

// var strng = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

// for (var i = 0; i <= strng.length; i++) {
//     var prntstrng = strng[i];
//     console.log(prntstrng)
// }
// var str = ['Rifat', 'RAfi', 'Aunoy ', 'Ontu']

// for (var i = 0; i < strng.length; i++) {
//     var prntstrng = str[i];
//     console.log(prntstrng)
// }

//even odd number with if condition::

// var odd = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
// for (var i = 0; i <= odd.length; i++) {
//     if (odd[i] % 2 != 0) {
//         console.log(odd[i])
//     }
// }

//even even number with if condition::

// var even = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
// for (var i = 0; i <= even.length; i++) {
//     if (even[i] % 3 == 0) {
//         console.log(even[i])
//     }

// }
// console.log(even[3])//for once



// even prime number with if condition::

var prime = [2, 3, 4, 5, 6, 7, 8, 9, 10];
var p2 = [];
var flag2 = 0;
for (var i = 0; i < prime.length; i++) {
    for (var j = 2; j < prime[i]; j++) {
        if (prime[i] % j == 0) {
            flag2++;
        }
    }
    if (flag2 == 0) {
        p2.push(prime[i]);
        // p2 = prime[i];
    }
    flag2 = 0;
}

for (var k = 2; k < p2.length; k++) {
    console.log(p2[k]);
}

// var x = 13, flag=0;

// for(var j=2; j<x; j++){
//     if(x%j == 0){
//         flag++;
//     }
// }

// if( flag == 0){
//     console.log('prime');
// }
// else{
//     console.log('Not');
// }