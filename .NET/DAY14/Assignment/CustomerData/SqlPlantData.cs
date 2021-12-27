using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.CustomerData
{
    public class SqlPlantData : IPlantData
    {
        private CompanyContext _companyContext;
        public SqlPlantData(CompanyContext companyContext)
        {
           _companyContext = companyContext;
        }
        public Plant AddPlant(Plant plant)
        {
            _companyContext.Plants.Add(plant);
            _companyContext.SaveChanges();
            return plant;
        }

        public List<Plant> GetPlants()
        {
            return _companyContext.Plants.ToList();
        }
    }
}
