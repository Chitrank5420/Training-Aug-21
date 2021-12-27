using FarmPe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmPe.Data
{
    public interface ICategoryData
    {
        Category EditCategory(Category category);
    }
}
