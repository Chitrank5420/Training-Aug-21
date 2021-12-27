using CRUDOperations.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperations.EmployeeData
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private EmployeeContext _context = null;
        private DbSet<T> table = null;

        public GenericRepository()
        {
            this._context = new EmployeeContext();
            table = _context.Set<T>();
        }
        public GenericRepository(EmployeeContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return table.AsEnumerable();
        }

        public T GetById(object Id)
        {
            return table.Find(Id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
