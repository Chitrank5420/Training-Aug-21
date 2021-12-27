using CRUDOperations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperations.EmployeeData
{
 
    public class MockEmployeeData : IEmployeeData
    {
        private List<Employee> employees = new List<Employee>()
    {
        new Employee()
        {
            Id = Guid.NewGuid(),
            Name = "EmployeeOne"
        },
        new Employee()
        {
            Id = Guid.NewGuid(),
            Name = "EmployeeTwo"
        }
    };

        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public Employee EditEmployee(Employee employee)
        {
            var existingemployee = GetEmployee(employee.Id);
            existingemployee.Name = employee.Name;
            return existingemployee;
        }

        public Employee GetEmployee(Guid id)
        { 
            return employees.SingleOrDefault(x => x.Id == id); 
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
