using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Person
    {
        private string FirstName, LastName, Email;
        private DateTime Dob;

        public Person()
        {
            FirstName = Console.ReadLine();
            LastName = Console.ReadLine();
            Email = Console.ReadLine();
            Dob = Convert.ToDateTime(Console.ReadLine());
        }
        public Person(string fname, string lname, string email, DateTime dob)
        {
            FirstName = fname;
            LastName = lname;
            Email = email;
            Dob = dob;
        }
        public Person(string fname, string lname, string email)
        {
            FirstName = fname;
            LastName = lname;
            Email = email;
        }
        public Person(string fname, string lname, DateTime dob)
        {
            FirstName = fname;
            LastName = lname;
            Dob = dob;
        }

        public string Adult
        {
            get
            {
                int years = DateTime.Now.Year - Dob.Year;
                if (years > 18)
                {
                    return ("You are adult");
                }
                else
                {
                    return("Not an Adult");
                }
            }
        }
        public string Sunsign
        {
            get
            {
                if ((Dob.Month == 3 && Dob.Day >= 21) || (Dob.Month == 4 && Dob.Day <= 19))
                {
                    return ("Aries");
                }
                else if ((Dob.Month == 4 && Dob.Day >= 20) || (Dob.Month == 5 && Dob.Day <= 20))
                {
                    return ("Taurus");
                }
                else if((Dob.Month == 5 && Dob.Day >= 21) || (Dob.Month == 6 && Dob.Day <= 20))
                {
                    return ("Gemini");
                }
                else if((Dob.Month == 6 && Dob.Day >= 21) || (Dob.Month == 7 && Dob.Day <= 22))
                {
                    return ("Cancer");
                }
                else if((Dob.Month == 7 && Dob.Day >= 23) || (Dob.Month == 8 && Dob.Day <= 22))
                {
                    return ("Leo");
                }
                else if((Dob.Month == 8 && Dob.Day >= 23) || (Dob.Month == 9 && Dob.Day <= 22))
                {
                    return ("Virgo");
                }
                else if((Dob.Month == 9 && Dob.Day >= 23) || (Dob.Month == 10 && Dob.Day <= 22))
                {
                    return ("Libra");
                }
                else if((Dob.Month == 10 && Dob.Day >= 23) || (Dob.Month == 11 && Dob.Day <= 21))
                {
                    return ("Scorpio");
                }
                else if((Dob.Month == 11 && Dob.Day >= 22) || (Dob.Month == 12 && Dob.Day <= 21))
                {
                    return ("Sagittarius");
                }
                else if((Dob.Month == 12 && Dob.Day >= 22) || (Dob.Month == 1 && Dob.Day <= 19))
                {
                    return ("Capricon");
                }
                else if((Dob.Month == 1 && Dob.Day >= 20) || (Dob.Month == 2 && Dob.Day <= 18))
                {
                    return ("Aquarius");
                }
                else 
                {
                    return("Pisces");
                }
            }
        }
        
        public string Birthday
        {
            get
            {
                if(Dob.Day == DateTime.Now.Day && Dob.Month == DateTime.Now.Month)
                {
                    return("Hurraahhhh!!! It's your birthday");
                }
                else
                {
                    return ("No it's not your birthday");
                }
            }
        }
        public string display()
        {
            return(FirstName + " " + LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] p = new Person[2];
            for(int i=0;i<2;i++)
            {
                p[i] = new Person();
            }
            Console.WriteLine("Name " + "Is Adult " + "Sunsign " + "Is birthday ");
            for (int i = 0; i < 2; i++)
            {
                Console.Write(p[i].display());
                Console.Write(p[i].Adult);
                Console.Write(p[i].Sunsign);
                Console.WriteLine(p[i].Birthday);         
            }
            Console.ReadLine();
        }
    }
}
