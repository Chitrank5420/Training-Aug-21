using System;
using System.Collections.Generic;

#nullable disable

namespace FarmPe.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentType { get; set; }

        public virtual OrderDetail OrderNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
