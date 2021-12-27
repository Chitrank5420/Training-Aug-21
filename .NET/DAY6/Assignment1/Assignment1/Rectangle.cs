using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Rectangle
    {

        public delegate void area(int a, int b);
        public void cal(int p,int q)
        {
            Console.WriteLine("Area of recatangle is : {0}", p * q);
        }
    }
}
