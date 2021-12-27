using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class DrugPatient
    {
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int DrugId { get; set; }
        public Drugs Drugs { get; set; }

    }
}
