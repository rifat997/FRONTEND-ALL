//Integer
var arr = [10, 11, 12, 13, 143];
var arrindex = arr.indexOf(13);
console.log(arrindex)
console.log(arr)

//string

var stting = ['Rifat, Ahmed , Rahul, Akib'];
console.log(stting)
var sttiing = ['Rifat', 'Onnay', 'EEE', 'Aronb'];
console.log(sttiing)

//count //lebth for count array elements::
console.log(sttiing.length)

//index number know ":"
//index of(name);
var book = ["onion", "Book1 ", "ele", "Bookerr"];
var bookindex = book.indexOf('onion');
console.log(bookindex);
// in index which book 
var sindex = book[3];
console.log(sindex)

//change index value or reolace'

var change= [9,11,12,13,14,15,15,16,18]
console.log(change)
change[0]=10;
change[8]=17;
console.log(change)

//push pop 
var lastbench = ['Annoy ', 'Onyu ' , 'Aminul','Mahbub'] 
console.log(lastbench);
lastbench.push('Rifat');
console.log (lastbench);

//pop
var lastpop = ['Annoy ', 'Onyu ' , 'Aminul','Mahbub'] 
lastpop.pop();
console.log(lastpop);

//add elements in the frist 
lastpop.unshift("Ushift ",'Belal');
console.log(lastpop);

//remove elements in the frist 
lastpop.shift();
console.log(lastpop);