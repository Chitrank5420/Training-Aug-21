using System;
using Tutlane;
using demo;

namespace Tutlane
{
    class User
    {
        internal string Name;
        internal string Location;
        internal int Age;
        internal void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.Name = "Suresh";
            u.Location = "Hyderabad";
            u.Age = 32;
            u.GetUserDetails();
            Console.ReadLine();
        }
    }
}
