﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FarmPe.Models
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Order Order { get; set; }
    }
}
