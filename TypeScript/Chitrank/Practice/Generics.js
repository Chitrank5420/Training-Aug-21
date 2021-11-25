var identity = function (arg) {
    return arg;
};
console.log(identity('1'));
/*
Generics with Non-Generics
function displayDataType<T,U,V>(id:T, name:U,email:V): void {
    console.log("DataType of Id: "+typeof(id) + "\nDataType of Name: "+ typeof(name) + "\nDataType of Email: " +
    typeof(email));
  }
  displayDataType<number,string,string>(1, "Abhishek","chitumarania@gmail.com");
  */ 
