using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment
{
    public class HealthCareAssistant
    {
        //Decalring Variables
        [Key]
        public int AssistantId { get; set; }
        public string AssistantName { get; set; }
        public int Age { get; set; }
        [ForeignKey("DeptID")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
