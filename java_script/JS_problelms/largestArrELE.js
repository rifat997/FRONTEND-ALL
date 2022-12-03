//21-5
function largestNumber(numbers) {
    // const largest =0;
    let largest = 0;
    for (let i = 0; i < numbers.length; i++) {
        const element = numbers[i];
        console.log("ALL THE ELEMENTS ARE ", element)
        // console.log(i);
        if (element > largest) {
            largest = element;
        }
        //  return largest;
    }
    return largest; 
}
    const ages = [20, 21, 22, 23, 34, 56, 67, 78];
    const biggest = largestNumber(ages);
    console.log(" The Biggest Number is " , biggest);