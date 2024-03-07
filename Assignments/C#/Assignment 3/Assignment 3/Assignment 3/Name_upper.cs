using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{

    class Name_upper
    {
        static void Main(string[] args)
        {
            // enter the first name
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            // enter the last name
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            // calling static method
            Display(firstName, lastName);
        }

        static void Display(string firstName, string lastName)
        {

            //Converting the firstname to uppercase
            Console.Write("First Name: ");
            PrintUppercase(firstName);

            //Converting the lastname to uppercase
            Console.Write("Last Name: ");
            PrintUppercase(lastName);

            // Using Inbuilt Function---

            //Console.WriteLine($"First Name: {firstName.ToUpper()}");
            //Console.WriteLine($"Last Name: {lastName.ToUpper()}");
            //Console.ReadLine();
        }

        // method to convert a name to uppercase
        static void PrintUppercase(string name)
        {
            foreach (char c in name)
            {
                if (c >= 'a' && c <= 'z')
                {
                    char uppercaseChar = (char)(c - ('a' - 'A'));
                    Console.Write(uppercaseChar);
                }
                else
                {
                    Console.Write(c);
                }
            }
            Console.ReadLine();
        }
    }
}