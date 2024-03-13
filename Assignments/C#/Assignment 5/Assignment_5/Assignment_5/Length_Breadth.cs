using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Box
    {
        // Member
        public double Length { get; set; }
        public double Breadth { get; set; }

        // Constructor
        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
    }

    //----------------------------

    class BoxOperations
    {
        public static Box AddBoxes(Box box1, Box box2)
        {
            double sumLength = box1.Length + box2.Length;
            double sumBreadth = box1.Breadth + box2.Breadth;

            return new Box(sumLength, sumBreadth);
        }
    }
    //-----------------------

    class Length_Breadth
    {
        static void Main()
        {
            Console.WriteLine("Enter dimensions for Box 1:");
            Console.Write("Length: ");
            double length1 = double.Parse(Console.ReadLine());

            Console.Write("Breadth: ");
            double breadth1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter dimensions for Box 2:");
            Console.Write("Length: ");
            double length2 = double.Parse(Console.ReadLine());

            Console.Write("Breadth: ");
            double breadth2 = double.Parse(Console.ReadLine());

            // Create Box objects
            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);

            // Add boxes
            Box resultBox = BoxOperations.AddBoxes(box1, box2);

            // Display result
            Console.WriteLine("\nResultant Box (Sum of Box 1 and Box 2):");
            Console.WriteLine($"Length: {resultBox.Length}");
            Console.WriteLine($"Breadth: {resultBox.Breadth}");
            Console.ReadLine();
        }
    }
}
//-------------------