using FarmPe.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmPe.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly FarmpeContext _farmpeContext;
        
      
        public GenericRepository(FarmpeContext farmpeContext)
        {
            this._farmpeContext = farmpeContext;
        }
        
        public void Delete(int id)
        {
            T existing = _farmpeContext.Set<T>().Find(id);
            _farmpeContext.Set<T>().Remove(existing);
            _farmpeContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _farmpeContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {       
            return _farmpeContext.Set<T>().Find(id);
        }

        public T Insert(T obj)
        {
            _farmpeContext.Set<T>().Add(obj);
            _farmpeContext.SaveChanges();
            return obj;
        }

    }
}
