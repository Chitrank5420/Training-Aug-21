using System;
using System.Collections.Generic;

namespace PracticeExercise
{
    class Student
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //LIST EXAMPLE
            List<string> s = new List<string>() { "chitrank", "yagnik", "manthan", "deep", "harsh" };
            Console.WriteLine("List Example");
            //Console.WriteLine("Please Enter Names : ");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("enter name : ");
            //    var name = Console.ReadLine();
            //    s.Add(name);
            //}
            Console.WriteLine();
            foreach (var s1 in s)
            {
                Console.WriteLine(s1);
            }
            Console.WriteLine("------------------------------------------------");

            ////STACK EXAMPLE
            Stack<int> s2 = new Stack<int>();
            Console.WriteLine("Stack Example");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please Enter age :");
                int age = Int32.Parse(Console.ReadLine());
                s2.Push(age);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(s2.Pop());
            }

            Console.WriteLine("------------------------------------------------");


            //DICTIONARY EXAMPLE
            Dictionary<string, int> Product = new Dictionary<string, int>();
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Please Enter Product Name :");
                string pname = Console.ReadLine();
                Console.WriteLine("Please Enter Product Price :");
                int price = Int32.Parse(Console.ReadLine());
                Product.Add(pname, price);
            }
            Console.WriteLine("Enter Product name to search : ");
            string search = Console.ReadLine();
            if(Product.ContainsKey(search))
                Console.WriteLine("Product : {0} Price :{1}",search,Product[search]);
            else
                Console.WriteLine("Item Not found");
            Console.ReadLine();
        }
    }
}
