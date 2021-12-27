using System;
using System.Linq;

namespace EFPractice3
{
    class Program
    {
        public static void Main(string[] args)
        {

            var context = new SchoolContext();
            //INSERT
            //var std = new Student()
            //{
            //    Name = "Yagnik"
            //};
            //context.Students.Add(std);
            //context.SaveChanges();

            //UPDATE
            //var st = context.Students.First<Student>();
            //st.Name = "Steven";
            //context.SaveChanges();

            //DELETE
            //var st = context.Students.First<Student>();
            //context.Students.Remove(st);


            //FIND METHOD
            //var s = context.Students.Find(1);
            //Console.WriteLine(s.StudentId);
            //Console.WriteLine(s.Name);
            //Console.ReadLine();

            
            //var studentsWithSameName = context.Students
            //                                  .Where(s => s.Name == GetName())
            //                                  .ToList();
            //Console.WriteLine(studentsWithSameName.Count);
            //Console.ReadLine();





        }
        //public static string GetName()
        //{
        //    return "Bill";
        //}

    }
}
