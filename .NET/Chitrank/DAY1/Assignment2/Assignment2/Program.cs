//Store your name in one string and find out how many vowel characters are there in your name.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int count = 0;
            foreach(char c in s)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O'
                    || c == 'U')
                    count++;
            }
            Console.WriteLine("total vowels in {0} are {1} ",s,count);
            Console.ReadLine();
        }
    }
}
