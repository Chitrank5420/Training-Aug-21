//Accept 10 student Name,Address,Hindi,English,Maths Marks ,do the total and compute Grade. Note do it with Array and
//display the result in grid format

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Student = new string[2, 5];
            int x = Student.GetLength(0);
            int y = Student.GetLength(1);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Student[i, j] = Console.ReadLine();
                }
            }
            Console.WriteLine("Name | " + "Address | " + "Hindi | " + "English | " + "Maths | " + "Total");

            for (int i = 0; i < x; i++)
            {
                int total = 0;
                for (int j = 0; j < y; j++)
                {
                    Console.Write(Student[i, j] + " | ");
                    if(j>1)
                    {
                        total += int.Parse(Student[i, j]);
                    }
                }
                Console.WriteLine(total);
                
            }
            Console.ReadLine();
        }
    }
}
