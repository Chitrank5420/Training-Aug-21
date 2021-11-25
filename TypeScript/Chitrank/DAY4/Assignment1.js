//Store 5 Employee Data(ID,Name,City,DOJ) in one Array. Search the employee with ID.
var employee = [
    { "EmpId": 1, "FirstName": "Chitrank", "LastName": "Umarania", "Address": "AHMEDABD", "DOJ": new Date(2021, 5, 3) },
    { "EmpId": 2, "FirstName": "Veer", "LastName": "Fadia", "Address": "Mumbai", "DOJ": new Date(2023, 5, 4) },
    { "EmpId": 3, "FirstName": "Krunal", "LastName": "Prajapati", "Address": "Mumbai", "DOJ": new Date(2020, 5, 8) },
    { "EmpId": 4, "FirstName": "Alpesh", "LastName": "Raval", "Address": "Delhi", "DOJ": new Date(2019, 5, 7) },
    { "EmpId": 5, "FirstName": "Hitesh", "LastName": "Patel", "Address": "Mumbai", "DOJ": new Date(2019, 5, 6) }
];
var id = 1;
console.log(employee[id - 1]);
//Search the employees who has joined after year 2020
for (var _i = 0, employee_1 = employee; _i < employee_1.length; _i++) {
    var items = employee_1[_i];
    if (items.DOJ.getFullYear() > 2020) {
        console.log(items);
    }
}
//Search the employee who has joined after year 2020 and stays in Mumbai city
for (var _a = 0, employee_2 = employee; _a < employee_2.length; _a++) {
    var items = employee_2[_a];
    if ((items.DOJ.getFullYear() > 2020) && (items.Address.toUpperCase() == 'MUMBAI')) {
        console.log(items);
    }
}
