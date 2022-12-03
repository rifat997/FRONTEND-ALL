//21-2
var frist =5;
var secound =7;
console.log(frist,secound)//5,7

var temp =frist;
frist = secound;
secound =temp;
console.log(frist,secound) //7,5

//shoetcut // destructing //array
var frist1=10;
var secound1=40;
[frist1, secound1] =[secound1, frist1]
console.log(frist1,secound1)