using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class DoctorPatient
    {
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
