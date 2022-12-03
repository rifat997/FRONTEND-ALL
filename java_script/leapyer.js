//find the leaper::20.4
function isleapyear (year){
    if(year % 4 == 0 ){
        return true;
    }
    else {
        return false;
    }
}
const myyear =2089;
const istheleapyaer = isleapyear( myyear);
    console.log('this year is ', istheleapyaer);