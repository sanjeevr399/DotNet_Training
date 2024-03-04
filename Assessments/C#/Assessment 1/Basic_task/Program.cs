using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check st = new Check();
            //st.Equal_or_not();

            //Positive_Negative ss = new Positive_Negative();
            //ss.Pos();

            //Math_Operation bb = new Math_Operation();
            //bb.CalculateOper();

            //Table tt = new Table();
            //tt.Table_no();

            //Triplet dd = new Triplet();
            //dd.Sum_triplet();

            //Day_Checker cc = new Day_Checker();
            //cc.Check_day();

            //Arrays ee = new Arrays();
            //ee.Array_all();

            Strings ab = new Strings();
            ab.String_one();

            Console.ReadLine();
        }
    }
}

    class Check
    {
        public void Equal_or_not()
        {
            int number1;
            int number2;

            Console.Write("Enter the first number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            number2 = int.Parse(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine("Both Numbers are equal");
            }
            else
            {
                Console.WriteLine("Both Numbers are not equal");
            }

        }
    }
