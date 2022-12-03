const products =[
    {name: 'laptop', price:43000},
    {name: 'shirt', price:500},
    {name: 'watch', price:3000},
    {name: 'lphone', price:53000},
    {name: 'bag', price:4000},
]
let totalprice =0;
for (const product of products) {
    totalprice = totalprice + product.price;
}
console.log(totalprice)