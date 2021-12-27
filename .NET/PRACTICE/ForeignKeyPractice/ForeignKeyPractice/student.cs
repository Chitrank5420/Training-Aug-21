using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace ForeignKeyPractice
{
    public class student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        [ForeignKey("CId")]
        public Course Courses { get; set; }
    }
}
