using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.CustomerData
{
    public interface IToyData
    {
        List<Toy> GetToys();
        Toy GetToy(int id);
    }
}
