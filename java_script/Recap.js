//array 
var favbook = "My Book";
var booklist = ["book1", "book2", "book3", "book4"];
var showindex = booklist.indexOf("book4");
booklist[1] = "BOOK2";
console.log(showindex);
//console.log(booklist);
booklist.push("BOOK5", "BOOK6");
booklist.pop();
console.log(booklist);




//condition::
if (booklist[2] == "book3") {
    console.log("I am book3 !!");
}
else {
    console.log("I am not book3 !!")
}


