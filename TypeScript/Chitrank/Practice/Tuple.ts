//Push operation

let mytup = [1,"chitrank",21,7778904407];

//Before Push
console.log(mytup);

//After Push
mytup.push("chitumarania@gmail.com");
console.log(mytup);

//Pop Operation
mytup.pop();
console.log(mytup);

//Updating Tuple

mytup[0]=10;
console.log(mytup);


//Desctructing the tuple
let [code,Name,Age,PhoneNo,Email] = mytup;

console.log(code);
console.log(Name);


//Using Functions
let empTuple = ["JavaTpoint", 101, "Abhishek"];     
//Passing tuples in function    
function display(tuple_values:any[]) {    
   for(let i = 0;i<empTuple.length;i++) {     
      console.log(empTuple[i]);    
   }      
}    
//Calling tuple in function    
display(empTuple);  


