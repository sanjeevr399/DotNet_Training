using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Word_Search
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a list of words:");
            string input = Console.ReadLine();

            // Parsing input
            string[] words = input.Split(',');

            // Query
            var filteredWords = words.Where(word =>
                                            word.Trim().ToLower().StartsWith("a") && 
                                            word.Trim().ToLower().EndsWith("m") 
                                        );

            // Print the output
            Console.WriteLine("Words starting with 'a' and ending with 'm':");
            foreach (var word in filteredWords)
            {
                Console.WriteLine(word.Trim());
            }

            Console.ReadLine();
        }
    }
}
