using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Books
    {
        // Member
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        // Constructor
        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        // Display method
        public void Display()
        {
            Console.WriteLine($"Book Name: {BookName}");
            Console.WriteLine($"Author Name: {AuthorName}");
        }
    }
    //---------------------------------

    class BookShelf
    {
        private Books[] books = new Books[5]; // Array to store books

        // Indexer
        public Books this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
    }

    //---------------------------------

    class Books_Display
    {
        static void Main(string[] args)
        {
            // Create a BookShelf
            BookShelf myBookShelf = new BookShelf();

            // Take user input for 5 books
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter Book {i + 1} Name: ");
                string bookName = Console.ReadLine();

                Console.Write($"Enter Author Name for {bookName}: ");
                string authorName = Console.ReadLine();

                // Instantiate a book and assign it to the BookShelf
                myBookShelf[i] = new Books(bookName, authorName);
            }

            // Display the details of all books
            Console.WriteLine("\nBook Details:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Book {i + 1}:");
                myBookShelf[i].Display();
                //Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}

//-------------
