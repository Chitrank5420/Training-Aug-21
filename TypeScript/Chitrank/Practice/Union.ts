let value: number|string;  
value = 120;  
console.log("Value: "+value);  
value = "Using Union";  
console.log("Value: "+value);  

//In function parameter
function display(value: (number | string))  
{  
    if(typeof(value) === "number")  
        console.log('The given value is of type number.');  
    else if(typeof(value) === "string")  
        console.log('The given value is of type string.');  
}  
display(123);  
display("ABC");  


//Using union in arrays
let arrType:number[]|string[];   
let i:number;   
arrType = [1,2,3,4];  
console.log("Numeric type array:")    
  
for(i = 0;i<arrType.length;i++){  
   console.log(arrType[i]);  
}  
arrType = ["India","America","England"];  
console.log("String type array:")    
  
for(i = 0;i<arrType.length;i++){   
   console.log(arrType[i]);  
}  


