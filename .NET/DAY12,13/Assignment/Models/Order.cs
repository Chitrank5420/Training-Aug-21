using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set;}
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int ToyId { get; set; }
        public Toy Toy { get; set; }

        public int TotalAmount { get; set; }
        public string PaymentType { get; set; }
        
        [ForeignKey("SchemeId")]
        public Schemes Schemes { get; set; }

        public int TotalAmountPaid { get; set; }

    }
}
