using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    // Define a delegate
    public delegate int CalculatorOperation(int a, int b);

    class Calculator_Func
    {
        static void Main(string[] args)
        {
            // Create instances of the delegate
            CalculatorOperation add = Add;
            CalculatorOperation subtract = Subtract;
            CalculatorOperation multiply = Multiply;

            // Inputs
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            // Perform calculations
            int sum = add(num1, num2);
            int difference = subtract(num1, num2);
            int product = multiply(num1, num2);

            // Display the results
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("What operation do you want + , - , *");
                char s = char.Parse(Console.ReadLine());
                if (s == '+')
                {
                    Console.WriteLine($"Sum: {sum}");
                }
                else if (s == '-')
                {
                    Console.WriteLine($"Difference: {difference}");
                }
                else
                {
                    Console.WriteLine($"Product: {product}");
                }
            }
            Console.ReadLine();
        }

        //operation methods
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}

//---------------------------------------------
