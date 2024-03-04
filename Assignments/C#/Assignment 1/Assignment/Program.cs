using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            Console.WriteLine(test("Python", 1));   
            Console.WriteLine(test("Python", 2)); 
            Console.WriteLine(test("Python", 3)); 
            Console.ReadLine();                 
        }
        public static string test(string str, int n)
        {
            //remove using inbuilt function
            return str.Remove(n, 1);   
        }
    }
}

//class Remove
//{
//    public static string Check(string str, int n)
//    {
//        int num;
//        Console.WriteLine("Enter the string");
//        string str =  Console.ReadLine();
//        Console.WriteLine("Enter the index n");
//        //Console.ReadLine();
//        num = int.Parse(Console.ReadLine());

//        return str.Remove(str,num);
//    }
//}
