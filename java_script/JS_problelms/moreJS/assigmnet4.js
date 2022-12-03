// problem----1;
function anaToVori(ana){
    if(typeof ana != "number"){
    return "Please enter number only!";
    }
    let vori = 0.0625 * ana;
    return vori;
    }
    let totalVori= anaToVori(16);
    // console.log(totalVori);
    // problem----2;
    function pandaCost( shingaraQuentati,samusaQuantati,zilapiQuantati){
    if(typeof shingaraQuentati != "number"){
    return "Please enter number only!";
    }
    if(typeof samusaQuantati != "number"){
    return "Please enter number only!";
    }
    if(typeof zilapiQuantati != "number"){
    return "Please enter number only!";
    }
    let shingaraPrice = 7 * shingaraQuentati;
    let samusaPrice = 10 * samusaQuantati;
    let zilapiiPrice = 15 * zilapiQuantati;
    const totalPrice = shingaraPrice + samusaPrice + zilapiiPrice ;
    return totalPrice;
    }
    let totalCost = pandaCost( 1,1,1);
    // console.log(totalCost);
    // problem----3;
    function picnicBudget(personNumber){
    if(typeof personNumber != "number"){
    return "Please enter number only!";
    }
    let totalSubscripition;
    if( personNumber <= 100 ){
    totalSubscripition = personNumber * 5000 ;
    }
    else if ( personNumber > 100 && personNumber <=200){
    let firstsubs = 100 * 5000 ;
    let remainingSubs = (personNumber - 100) * 4000 ;
    totalSubscripition = firstsubs + remainingSubs;
    }
    else if ( personNumber > 200 ){
    let firstSubs = 100 * 5000;
    let secondSubs = 100 * 4000;
    let remainingSubsTotal = (personNumber - 200) * 3000;
    totalSubscripition = firstSubs + secondSubs + remainingSubsTotal ;
    }
    return totalSubscripition;
    }
    let calculatSubscripition = picnicBudget(10);
    // console.log (calculatSubscripition);
    // problem----4;
    function oddFriend(friends){
    if(typeof friends == "number"){
    return 'please enter string only!'
    }
    for(let i = 0; i < friends.length; i++){
    let cheakFriend = friends[i];
    if ( cheakFriend.length % 2 != 0){
    return cheakFriend;
    }
    }
    }
    let friendList = [ 'asif','alif','tuhin','sabbir','ibrahim','tanvir'];
    // console.log(oddFriend(friendList));