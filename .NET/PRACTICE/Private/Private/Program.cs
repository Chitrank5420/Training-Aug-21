using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private
{
    class Person
    {
        private string Name;
        private string Email;
        public void set(string Name,string Email)
        {
            this.Name = Name;
            this.Email = Email;
        }
        public void display()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Email : " + Email);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.set("Chitrank", "chitumarania@gmail.com");
            p.display();
            Console.ReadLine();
        }
    }
}
