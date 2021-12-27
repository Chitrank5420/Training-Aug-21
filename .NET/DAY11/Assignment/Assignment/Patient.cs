using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class Patient
    {
        //Declaring Variables
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string PhoneNo { get; set; }
        public int Age { get; set; }

        //Foreign Key
        public int DepartmentId { get; set; }

        //Reference Navigation Property
        public Department Departments { get; set; }

        public int RoomId { get; set; }
        public Room Room{get;set; }

        public int AssistantId { get; set; }
        public HealthCareAssistant HealthCareAssistant { get; set; }
        public IList<DoctorPatient> DoctorPatients { get; set; }
        public IList<DrugPatient> DrugPatient { get; set; }
    }
}
