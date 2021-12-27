using System;
using System.Collections.Generic;

#nullable disable

namespace EFPractice.Models
{
    public partial class Job
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
    }
}
