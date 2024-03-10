using System;
using Concession_app;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        private const int TotalFare = 500;

        static void Main()
        {
            TicketConcession ticket = new TicketConcession();

            Console.Write("Enter Name: ");
            ticket.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            ticket.Age = int.Parse(Console.ReadLine());

            ticket.CalculateConcession();
            Console.ReadLine();
        }
    }
}