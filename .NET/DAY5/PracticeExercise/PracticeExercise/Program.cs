using System;
using System.Collections.Generic;

namespace PracticeExercise
{
    class Student
    {
        public int Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //LIST EXAMPLE
            Student s = new Student() { Name = 90 };
            Student s1 = s;
            s1.Name++;
            Console.WriteLine(s.Name);
            Console.WriteLine(s1.Name);
        }
    }
}
