/*
Assignment : Store 5 employees’ data in one array (ID,FirstName,LastName,Address,Salary). 
Do the operation searching by indexnumber, EmployeeID, Insert the employee, delete the employee 
from the Array. Create one more array emp and join the value with above array. When display list 
combine firstname and lastname as fullname, From the address field flatnumber,city,state and should be 
splited.PF should be computed and total salary should be display.
*/


var employee : any[] =[
    {"EmpId" : 1,"FirstName" : "Chitrank","LastName" : "Umarania","Address" : "B-702,KESAR ORCHID,NARODA,AHMEDABD,GUJARAT","Salary":30000},
    {"EmpId" : 2,"FirstName" : "Veer","LastName" : "Fadia","Address" : "D1001 Shree Ram,Shahibaug,AHMEDABD,GUJARAT","Salary":25000},
    {"EmpId" : 3,"FirstName" : "Krunal","LastName" : "Prajapati","Address" : "A501 Shree Ram Residency,NARODA,AHMEDABD,GUJARAT","Salary":15000},
    {"EmpId" : 4,"FirstName" : "Alpesh","LastName" : "Raval","Address" : "A002 Mahadev Residency,Bopal,AHMEDABD,GUJARAT","Salary":50000},
    {"EmpId" : 5,"FirstName" : "Hitesh","LastName" : "Patel","Address" : "B801 Balaji Residency,Sarkhej,AHMEDABD,GUJARAT","Salary":60000}
]


//Get All Employees
employee.forEach(Element =>{
    console.log(Element);
})


//Get Employee By Index Number
console.log(employee[0]);

//Get Employee By EmployeeID
var Id : number = 1
console.log(employee[Id-1]);


//Insert Employee
var newEmp = {"EmpId" : 6,"FirstName" : "Kruti","LastName" : "Umarania","Address" : "B-702,KESAR ORCHID,NARODA,AHMEDABD,GUJARAT","Salary":70000};
employee.push(newEmp);

employee.forEach(Element =>{
    console.log(Element);
})


//Delete Employee
console.log(employee.pop());


//Concat Two Array
var newArray =[{"EmpId" : 7,"FirstName" : "Sudhir","LastName" : "Umarania","Address" : "B-702,KESAR ORCHID,NARODA,AHMEDABD,GUJARAT","Salary":70000}]
employee=employee.concat(newArray);
for(var item of employee){
    console.log(item);
}


//Formated Display
for(var item of employee)
{
    console.log('Employee Id : ' + item.EmpId + " " + "Full Name : " + (item.FirstName +" "+ item.LastName)+" " + 
    "Address : " + item.Address.split(',')+" " + "Salary : " + item.Salary+" " + "PF : " + (item.Salary)*0.12);
}


