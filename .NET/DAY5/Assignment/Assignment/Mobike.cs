using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Mobike
    {
        int BikeNumber;
        string PhoneNumber;
        string Name;
        int Days;
        int rent;
        public void Input()
        {
            Console.WriteLine("Enter Bike Number : ");
            BikeNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Phone Number : ");
            PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter no of days to rent : ");
            Days = Int32.Parse(Console.ReadLine());                
        }
        public void Compute()
        {
            if(Days<=5)
            {
                rent = Days * 500;
            }
            else if(Days<=10)
            {
                rent = 2500 + ((Days - 5) * 400);
            }
            else
            {
                rent = 4500 + ((Days - 10) * 200);
            }
        }
        public void Display()
        {
            Console.WriteLine("Bike Number : {0} , PhoneNumber : {1} ,Name : {2} ,Days :{3},Rent : {4}",BikeNumber,PhoneNumber,Name,Days,rent );
        }
    }
}
