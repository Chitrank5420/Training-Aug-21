var employee = [
    { "EmpId": 1, "FirstName": "Chitrank", "LastName": "Umarania", "Address": "B-702,KESAR ORCHID,NARODA,AHMEDABD,GUJARAT", "Salary": 30000 },
    { "EmpId": 2, "FirstName": "Veer", "LastName": "Fadia", "Address": "D1001 Shree Ram,Shahibaug,AHMEDABD,GUJARAT", "Salary": 25000 },
    { "EmpId": 3, "FirstName": "Krunal", "LastName": "Prajapati", "Address": "A501 Shree Ram Residency,NARODA,AHMEDABD,GUJARAT", "Salary": 15000 },
    { "EmpId": 4, "FirstName": "Alpesh", "LastName": "Raval", "Address": "A002 Mahadev Residency,Bopal,AHMEDABD,GUJARAT", "Salary": 50000 },
    { "EmpId": 5, "FirstName": "Hitesh", "LastName": "Patel", "Address": "B801 Balaji Residency,Sarkhej,AHMEDABD,GUJARAT", "Salary": 60000 }
];
//Get All Employees
/*
employee.forEach(Element =>{
    console.log(Element);
})


//Get Employee By Index Number
console.log(employee[0]);
*/
//Get Employee By EmployeeID
/*
var Id : number = 1
console.log(employee[Id-1]);
*/
//Insert Employee
/*
var newEmp = {"EmpId" : 6,"FirstName" : "Kruti","LastName" : "Umarania","Address" : "B-702,KESAR ORCHID,NARODA,AHMEDABD,GUJARAT","Salary":70000};
employee=employee.push(newEmp);

employee.forEach(Element =>{
    console.log(Element);
})
*/
//Delete Employee
console.log(employee.pop());
//Concat Two Array
/*
var newArray =[{"EmpId" : 7,"FirstName" : "Sudhir","LastName" : "Umarania","Address" : "B-702,KESAR ORCHID,NARODA,AHMEDABD,GUJARAT","Salary":70000}]
employee=employee.concat(newArray);
for(var item of employee){
    console.log(item);
}*/
//Formated Display
for (var _i = 0, employee_1 = employee; _i < employee_1.length; _i++) {
    var item = employee_1[_i];
    console.log('Employee Id : ' + item.EmpId + " " + "Full Name : " + (item.FirstName + " " + item.LastName) + " " +
        "Address : " + item.Address.split(',') + " " + "Salary : " + item.Salary + " " + "PF : " + (item.Salary) * 0.12);
}
