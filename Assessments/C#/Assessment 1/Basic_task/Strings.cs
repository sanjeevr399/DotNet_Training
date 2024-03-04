using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_task
{
    class Strings
    {
        public void String_one()
        {
            Console.Write("Enter a word to calculate a length: ");
            string userInput = Console.ReadLine();

            int length = userInput.Length;

            Console.WriteLine($"Length of the word: {length}");
            Console.WriteLine("---------------------------------");
            //-----------------------------------------------------------------

            string str = "", reverse = "";
            int Length = 0;

            Console.WriteLine("Enter a Word for reverse the word");
            str = Console.ReadLine();
            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
            Console.WriteLine("Reverse word is {0}", reverse);
            Console.WriteLine("---------------------------------");
            //-----------------------------------------------------------------

            Console.Write("Enter the first word: ");
            string firstWord = Console.ReadLine();

            Console.Write("Enter the second word: ");
            string secondWord = Console.ReadLine();

            bool areSame = String.Equals(firstWord, secondWord, StringComparison.OrdinalIgnoreCase);

            if (areSame)
            {
                Console.WriteLine("The words are the same.");
            }
            else
            {
                Console.WriteLine("The words are different.");
            }
        }
    }
}
