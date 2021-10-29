using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public
{
    class Employee
    {
        public int Id;
        public string Name;

        public void display()
        {
            Console.WriteLine("Employee Code : " + Id);
            Console.WriteLine("Employee Name : " + Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Id = 001;
            e1.Name = "Chitrank Umarania";
            e1.display();
            Console.ReadLine();
        }
    }
}
