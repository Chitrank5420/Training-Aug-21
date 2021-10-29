//Accept Age from user, if age is more than 18 eligible for vote otherwise it should be displayed as not eligible.
//Do it with ternary operator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Your Age : ");
            int age = int.Parse(Console.ReadLine());
            var result = age > 18 ? "You are eligible" : "You are not eligible";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
