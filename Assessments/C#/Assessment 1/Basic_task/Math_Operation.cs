using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_task
{
    class Math_Operation
    {
        public void CalculateOper()
        {
            int n1, n2;
            char operation;
            Console.Write("Input first number: ");
            n1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input operation: ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Input second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
                    break;
                case '-':
                    Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
                    break;
                case '*':
                case 'x':
                    Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
                    break;
                case '/':
                    Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
                    break;
                default:
                    Console.WriteLine("Invalid operator entered. Please use +, -, *, or /.");
                    break;
            }
        }
    }
}
