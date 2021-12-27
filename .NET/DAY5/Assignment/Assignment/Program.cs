using System;
using System.Collections.Generic;

namespace Assignment
{
     
    class Program
    {
        static void Main(string[] args)
        {

            var m1 = new List<Mobike>();
            for(int i =0;i<10;i++)
            {
                m1.Add(new Mobike());
            }
            for(int i =0;i<10;i++)
            {
                m1[i].Input();
                m1[i].Compute();
                m1[i].Display();
            }
            Console.ReadLine();
        }3
         4
    }
}
