using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Models
{
    public class Toy
    {
        public int ToyID { get; set; }
        public string ToyName { get; set; }
        public string Price { get; set; }

        public int PlantId { get; set; }
        public Plant Plant { get; set; }
    }
}
