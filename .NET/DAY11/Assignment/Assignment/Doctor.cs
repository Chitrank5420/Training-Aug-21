using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class Doctor
    {
        //Declaring Variables
        public int DoctorID { get; set;}
        public string DoctorName { get; set; }
        public string Qualification { get; set; }
        public int Experience { get; set; }             //Experience in Years

        public IList<DoctorPatient> DoctorPatients{ get; set; }
    }
}
