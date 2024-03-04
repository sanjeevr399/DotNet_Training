using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_task
{
    class Triplet
    {
        public void Sum_triplet()
        {
            int a, b, c;
            Console.WriteLine("enter a number a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number b: ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            if (a == b)
            {
                int d = 3 * c;
                Console.WriteLine($"triplet of a and b {d}");
            }
            else
            {
                Console.WriteLine($"sum of a and b {c}");
            }
        }
    }
}
