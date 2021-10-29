using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            for(int i=0;i<=10;i++)
            {
                if(i%2==0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum of Even numbers between 0 to 10 : {0}", sum);
            Console.ReadLine();
        }
    }
}
