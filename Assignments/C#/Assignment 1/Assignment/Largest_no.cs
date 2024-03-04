using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Largest_no
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine(test(1, 4, 3));  
            Console.WriteLine(test(1, 3, 2));  
            Console.WriteLine(test(1, 1, 2));  
            Console.WriteLine(test(1, 7, 2));  
            Console.ReadLine();               
        }

       
        public static int test(int x, int y, int z)
        {
            // using inbuild function
            var max = Math.Max(x, Math.Max(y, z));  // Max is used to find the max of the number.

            return max;
        }
    }
}



