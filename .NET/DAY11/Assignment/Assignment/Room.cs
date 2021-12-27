using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment
{
    public class Room
    {
        //Declaring Variables
        public int RoomId { get; set; }
        [MaxLength(20)]                             //Using DataAnnonations 
        public bool ACRoom { get; set; }            //Is AC Room or Not ?
        public bool ICURoom { get; set; }           //Is it ICU Room ?

        
        public Patient Patient { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
