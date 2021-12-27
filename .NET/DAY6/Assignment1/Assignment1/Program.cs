//Compute area of rectangle using func delegate


using System;

namespace Assignment1
{
    
    class Program
    {
        
        static void Main(string[] args)
        {

            Rectangle r = new Rectangle();
            Rectangle.area a = new Rectangle.area(r.cal);
            a(10, 20);
        }
    }
}
