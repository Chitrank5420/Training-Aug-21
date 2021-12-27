using FarmPe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmPe.Data
{
    public class SqlCategoryData : ICategoryData
    {
        private readonly FarmpeContext _farmpeContext;

        public SqlCategoryData(FarmpeContext farmpeContext)
        {
            _farmpeContext = farmpeContext;
        }

        public Category EditCategory(Category category)
        {

            var myCategory = _farmpeContext.Categories.Find(category.CategoryId);
            if(category != null)
            {
                myCategory.CategoryId = category.CategoryId;
                myCategory.CategoryName = category.CategoryName;
                myCategory.NoOfProducts = category.NoOfProducts;
                _farmpeContext.Categories.Update(myCategory);
                _farmpeContext.SaveChanges();
            }
            return myCategory;
        }
    }
}
