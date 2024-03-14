using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Assessment_3
{
    class Append_txt
    {
        static void Main()
        {
            Console.WriteLine("write a message do you want to append in the file");
            //specify the fie name
            string fileName = "mytext.txt";
            string textToAppend = Console.ReadLine();

            try
            {

                // Create the file and write initial content to it
                using (StreamWriter fileStream = File.CreateText(fileName))
                {
                    // Writing initial content to the file
                    fileStream.WriteLine("Hello and Welcome");
                    fileStream.WriteLine("It is the first content");
                    fileStream.WriteLine("of the text file mytest.txt");
                }

                using (StreamWriter sw = new StreamWriter(fileName, true))
                {
                    sw.WriteLine(textToAppend);
                }

                //succefully appended
                Console.WriteLine("Text appended to the file successfully.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}