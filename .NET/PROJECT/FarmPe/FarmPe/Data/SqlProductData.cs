using FarmPe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmPe.Data
{
    public class SqlProductData : IProductData
    {
        private readonly FarmpeContext _farmpeContext;

        public SqlProductData(FarmpeContext farmpeContext)
        {
            _farmpeContext = farmpeContext;
        }
        public Product EditProduct(Product product)
        {
            var existingProduct = _farmpeContext.Products.Find(product.ProductId);
            if(existingProduct != null)
            {
                existingProduct.ProductId = product.ProductId;
                existingProduct.ProductName = product.ProductName;
                existingProduct.ProductCategory = product.ProductCategory;
                existingProduct.Rate = product.Rate;
                existingProduct.CategoryId = product.CategoryId;
                _farmpeContext.Products.Update(existingProduct);
                _farmpeContext.SaveChanges();
            }
            return existingProduct;
        }
    }
}
