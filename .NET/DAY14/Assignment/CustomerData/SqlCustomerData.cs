using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.CustomerData
{
    public class SqlCustomerData : ICustomerData
    {
        private CompanyContext _companyContext;
        public SqlCustomerData(CompanyContext companyContext)
        {
            _companyContext = companyContext;
        }
        public Customer AddCustomer(Customer customer)
        {
            _companyContext.Customers.Add(customer);
            _companyContext.SaveChanges();
            return (customer);
        }

        public List<Customer> GetCustomers()
        {
            return _companyContext.Customers.ToList();
        }

        public Customer EditCustomer(Customer customer)
        {
            var cus = _companyContext.Customers.Find(customer.CustomerId);
            if(cus != null)
            {
                cus.CustomerName = customer.CustomerName;
                _companyContext.Customers.Update(cus);
                _companyContext.SaveChanges();
            }
            return cus;
        }

        public Customer GetCustomer(int id)
        {
            return _companyContext.Customers.Find(id);
        }
        public void DeleteCustomer(Customer customer)
        {
            _companyContext.Customers.Remove(customer);
            _companyContext.SaveChanges();
        }
    }
}
