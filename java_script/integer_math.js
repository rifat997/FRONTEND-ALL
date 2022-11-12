// varaiableneeds 5 things var name=value;
var egg=40;
var pen=5;
console.log(egg);
console.log(egg+pen);
var hen=200;
var rice=75;
var total = hen+rice;
console.log(total)
//recap +,_,*,/ =operator
var p=10;
var z=20;
var sum=p+z;
var dif=p-z;
var mul=p*z;
var div=p/z;
console.log(sum);
console.log(dif);
console.log(mul);
console.log(div);
//new turm
// if ypu want to update previous value just use vabiable name
//not var p=30 ; just use p=p+40;
//or p+=40;
p=p+40;//shorthands will be p+=40;
console.log(p);
console.log(sum);
console.log(dif);
console.log(mul);
console.log(div);
//if just 1 will increase you can write ++ so p++ or p--
p++
console.log(p);

// Dot .
var r=99.999999999;
var y=45.55;
//var add = parseInt (r+y);
var add = parseFloat (r+y);//.0000
console.log(add);
var a=20.0000;
var b=30.000;
var addint= parseInt(a+b) ;//just 1,2 etc
console.log(addint);
//special edition:
//only show for .1,.2(other value is noraml)
var s1=0.1;
var s2=0.2;
var total=s1+s2;
total=total.toFixed(1);//toFixed is the keyword//1 is for to take 1 decimal value like 0.3
console.log(total);
//modulus:
var man=8;
var nam=2;
var remaining =man%nam;
console.log(remaining);
console.log(typeof man);


