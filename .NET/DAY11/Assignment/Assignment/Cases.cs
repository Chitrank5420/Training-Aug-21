using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment
{
    public class Cases
    {   
        //Declaring Variables
        [Key]
        public int CaseId { get; set; }
        public string Issue { get; set; }
        public DateTime CaseDate { get; set; }    

        //Foreign Key
        public int PatientId { get; set; }

        //Reference Navigation Property
        public Patient Patient { get; set; }

    }
}
