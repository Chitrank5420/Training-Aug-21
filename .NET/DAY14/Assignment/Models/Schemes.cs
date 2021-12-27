using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment.Models
{
    public class Schemes
    {
        public static int Id { get; internal set; }
        [Key]
        public int SchemeId { get; set; }
        public int OrderAmount { get; set; }
        public int DiscountAmount { get; set; }

    }
}
