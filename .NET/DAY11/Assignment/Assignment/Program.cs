using System;
using System.Linq;

namespace Assignment
{
    public class Program
    {
      
        public static void Main(string[] args)
        {
            using(var context = new HospitalContext())
            {
                //Inserting Doctor

                var doc = new Doctor()
                {
                    DoctorName = "Steven Smith",
                    Qualification = "MD",
                    Experience = 15
                };
                context.Doctors.Add(doc);
                context.SaveChanges();


                //Updating Doctor

                //var doc = context.Doctors.First<Doctor>();
                //doc.Experience = 13;
                //context.SaveChanges();


                //Deleting Doctor

                //var doc = context.Doctors.First<Doctor>();
                //context.Doctors.Remove(doc);
                //context.SaveChanges();


                




            }
        }
    }
}
