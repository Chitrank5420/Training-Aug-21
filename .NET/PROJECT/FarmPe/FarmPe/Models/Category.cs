using System;
using System.Collections.Generic;

#nullable disable

namespace FarmPe.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int NoOfProducts { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
