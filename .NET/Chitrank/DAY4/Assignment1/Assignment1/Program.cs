using System;
using System.Text.RegularExpressions;

namespace Assignment1
{

    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = null;
            try
            {
                s1 = new Student();
                s1.ID = 1;
                s1.Name = "Chitrank00";
                s1.Age = -1;
                s1.Date = new DateTime(2000,05,04);
                validate(s1);
            }
            catch (InvalidNameException e1)
            {
                Console.WriteLine(e1.Message);
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(InvalidDateException e2)
            {
                Console.WriteLine(e2.Message);
            }

           
            Console.ReadLine();

           
           
        }
        private static void validate(Student s)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(s.Name))
                throw new InvalidNameException(s.Name);

            if (s.Age < 0)
                throw new InvalidAgeException(s.Age);

            if (s.Date != DateTime.Now)
                throw new InvalidDateException(s.Date);

        }

    }
}
