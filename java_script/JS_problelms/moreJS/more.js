//22-1:: very important
//max
function largestElement(numbers1) {
    let max = numbers1[0];
    for (let i = 0; i < numbers1.length; i++) {
        const element = numbers1[i];
        if (element > max) {
            max = element;
        }
    }
    return max;
}
const biggest = largestElement([0, 21, 22, 23, 34, 56, 67, 78, 99])
console.log("the bigges  number is ", biggest)


//min
function smallestElement(numbers) {
    let min = numbers[0];
    for (let i = 0; i < numbers.length; i++) {
        const element = numbers[i];
        if (element < min) {
            min = element;
        }
    }
    return min;
}

// const ages = [20, 21, 22, 23, 34, 56, 67, 78];
const smallmin = smallestElement([0, 21, 22, 23, 34, 56, 67, 78])
console.log("the smallest minimum number is ", smallmin)
