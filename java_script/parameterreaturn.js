//4.19.3
// function item(prize) {
//     console.log('Bring my item', prize);
//     console.log('Bring it more' + prize);
// }

// item(100)


//
function itom(money) {
    console.log('Bring my item', money);
    console.log('Bring it more');
    var car = 1000;
    var total = money / car;
    return total;
}

var amount = 250;
var totalitem = itom(amount);
console.log("take it ", totalitem)
