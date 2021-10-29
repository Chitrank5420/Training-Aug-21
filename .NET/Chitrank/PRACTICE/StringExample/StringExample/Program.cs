using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Clone Method
            string s1 = "Chitrank";
            string s2 = (String)s1.Clone();
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            //Compare Method
            //s1 == s2 returns 0  
            //s1 > s2 returns 1
            //s1 < s2 returns - 1

            string first = "hello";
            string second = "hello";
            string third = "thir";

            Console.WriteLine(string.Compare(first,second));
            Console.WriteLine(string.Compare(first,third));
            Console.WriteLine(string.CompareOrdinal(first, third));
            Console.ReadLine();



        }
    }
}
