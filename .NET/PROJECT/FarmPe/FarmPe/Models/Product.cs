using System;
using System.Collections.Generic;

#nullable disable

namespace FarmPe.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public decimal Rate { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
