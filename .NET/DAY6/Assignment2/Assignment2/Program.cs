//Compute add of two number using lambda expression


using System;

namespace Assignment2
{
    class Program
    {
        //public delegate int sum(int num1,int num2);
        static void Main(string[] args)
        {
            //sum s = (x,y)=> x+y;
            //int j = s(5, 10);
            //Console.WriteLine(j);

            Func<int, int, int> sum = (x, y) => x + y;
            Console.WriteLine(sum.Invoke(5,10));
            Console.ReadLine();
        }
    }
}
