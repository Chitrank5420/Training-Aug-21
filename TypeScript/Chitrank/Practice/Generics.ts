
let identity= <T>(arg:T) => {
    return arg;
}

console.log(identity<string>('1'));

//Generics with Non-Generics
function displayDataType<T,U,V>(id:T, name:U,email:V): void {   
    console.log("DataType of Id: "+typeof(id) + "\nDataType of Name: "+ typeof(name) + "\nDataType of Email: " +
    typeof(email));    
  }  
  displayDataType<number,string,string>(1, "Abhishek","chitumarania@gmail.com");  


//Using Generics in Class
class Student {  
    Id: number;  
    Name: string;  
  
    constructor(id:number,  name:string) {   
        this.Id = id;  
        this.Name = name;  
    }  
}  
function Display<T extends Student>(per: T): void {  
    console.log(`${ st.Id} ${st.Name}` );  
}  
var st = new Student(1, "\nChitrank");  
Display(st);  


var arr : (string | number)[][] = [["1",1],["2",2]];