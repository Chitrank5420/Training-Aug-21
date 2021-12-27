using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment
{
    public class Department
    {
        //Declaring Variables
        [Key]                                       //Using DataAnnonations
        public int DepartmentId { get; set; }       
        public string DeptName { get; set; }
        public int FloorNo { get; set; }            //Indicates on which floor Dept Exists

    }
}
