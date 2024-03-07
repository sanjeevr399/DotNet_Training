using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Scholarship
    {
        public double Merit(int marks, double fees)
        {
            double scholarshipAmount = 0;  

            // conditions for scholarship
            if (marks >= 70 && marks <= 80)
            {
                scholarshipAmount = 0.20 * fees;
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = 0.30 * fees;
            }
            else if (marks > 90)
            {
                scholarshipAmount = 0.50 * fees;
            }

            return scholarshipAmount;
        }
    }

    class Scholar

    {
        static void Main()
        {
            Scholarship scholarship = new Scholarship();

            Console.Write("Enter marks: ");
            int marks = int.Parse(Console.ReadLine());

            Console.Write("Enter fees: ");
            double fees = double.Parse(Console.ReadLine());

            double scholarshipAmount = scholarship.Merit(marks, fees);

            Console.WriteLine($"Scholarship amount: {scholarshipAmount}");
            Console.Read();
        }
    }
}