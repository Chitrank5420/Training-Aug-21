using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; set; }
    }

    
    class InvalidAgeException : Exception
    {
        public InvalidAgeException() { }

        public InvalidAgeException(int age)
            : base("Invalid age : " + age)
        {

        }
    }
    class InvalidNameException : Exception
    {
        public InvalidNameException() { }
        
        public InvalidNameException(string name)
            : base("Invalid name : " + name)
        {

        }
    }

    class InvalidDateException : Exception
    {
        public InvalidDateException() { }
        public InvalidDateException(DateTime d)
            : base("Invalid Date :" + d)
        {

        }
    }
}
