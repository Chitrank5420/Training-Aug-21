using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected
{
    class User
    {
        protected int Id;
        protected string Name;
        public void display()
        {
            Console.WriteLine("Id : " + Id);
            Console.WriteLine("Name : " + Name);
        }
    }
    class Program : User
    {
        static void Main(string[] args)
        {
            //User u = new User(); // This will generate error
            Program p = new Program();
            p.Id = 1;
            p.Name = "Chitrank";
            p.display();
            Console.ReadLine();
        }
    }
}
