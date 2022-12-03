//22-7
// cheapest phone from an array ::

const phones =[
    {name:"sumsung s5",prize:45000, camera:48, storage:32},
    {name:"nokia s5",prize:5000, camera:8, storage:32},
    {name:"samphony s5",prize:15000, camera:4, storage:32},
    {name:"walton s5",prize:12000, camera:4, storage:32},
    {name:"iphone s5",prize:20000, camera:8, storage:32},
    {name:"habizabi s5",prize:3000, camera:4, storage:32},
    {name:"oneplus s5",prize:34000, camera:8, storage:32},
];
let cheapest = phones[0];
for (const phone of phones) {
    // console.log(phone)
    if (phone.prize < cheapest.prize) {
        // phone = cheapest;
        cheapest =phone;
    }
}
console.log(cheapest);