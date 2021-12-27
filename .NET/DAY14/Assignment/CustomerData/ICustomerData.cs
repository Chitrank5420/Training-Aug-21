using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.CustomerData
{
    public interface ICustomerData
    {
        Customer GetCustomer(int id);
        List<Customer> GetCustomers();
        Customer AddCustomer(Customer customer);

        Customer EditCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        
    }
}
