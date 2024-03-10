using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Square_no
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter a list of numbers: ");
            string input = Console.ReadLine();

           
            string[] numberStrings = input.Split(',');
            List<int> numbers = new List<int>();

            foreach (string numString in numberStrings)
            {
                if (int.TryParse(numString.Trim(), out int number))
                {
                    numbers.Add(number);
                }
            }

            // query
            var squaresGreaterThan20 = numbers.Select(num => new { Number = num, Square = num * num })
                                               .Where(pair => pair.Square > 20)
                                               .ToList();

            // Printing
            Console.WriteLine("Numbers and their squares greater than 20:");
            foreach (var pair in squaresGreaterThan20)
            {
                Console.WriteLine($"{pair.Number} : {pair.Square}");
            }

            Console.ReadLine();
        }
    }
}