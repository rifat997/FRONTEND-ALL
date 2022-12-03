//20-22
const names = ['rifat', 'rohan', 'anik', 'rifat', 'rifat' , 'anik ', "sommooo ",  'shuvo ', 'sumaiya','nahrin', 'anika ' , 'vanika', 'nanika' ];

function duplicate(names) {
    const unique =[];
    // for (let i = 0; i < names.length; i++) {
    //     const element = names[i];
    //     console.log(element);    
    // }
   //for of loop ::
    for (const element of names) {
        // console.log (unique)
        console.log (element)
        if (unique.indexOf(element) == -1) {
           unique.push(element); 
        }
    }
    // return names;
     return unique;
}
const allnames = duplicate(names);
console.log(allnames);