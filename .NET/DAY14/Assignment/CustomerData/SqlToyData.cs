using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.CustomerData
{
    public class SqlToyData : IToyData
    {
        private CompanyContext _comapnyContext;
        public SqlToyData(CompanyContext companyContext)
        {
            _comapnyContext = companyContext;
        }
        public Toy GetToy(int id)
        {
            return _comapnyContext.Toys.Find(id);
        }

        public List<Toy> GetToys()
        {
            return _comapnyContext.Toys.ToList();
        }
    }
}
