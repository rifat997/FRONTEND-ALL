//21-6
// [0 1 1 2 3 5 8 13 21 34 55]
/*
3rd = 2nd+ 1st
4 th = 3rd + 2nd
nth = (n-1)th + (n-2th)
*/
const fibo = [0, 1]
for (let i = 2; i <= 10; i++) {
    fibo[i] = fibo[i - 1] + fibo[i - 2];
}
console.log(fibo)