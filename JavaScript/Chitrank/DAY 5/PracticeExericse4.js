//Using Function call create employee object with field Name, Address and Designation and pass it to function.
//call() method takes arguments separtely
function Employee(FieldName, Address, Designation) {
    console.log(this.Name + " " + FieldName + " " + Address + " " + Designation);
}

const emp1 = {
    Name: "Chitrank"
}
const emp2 = {
    Name: "Harsh"
}
const emp3 = {
    Name: "Mehul"
}

Employee.call(emp1, "Developer", "Ahmedabad", "Senior Developer")