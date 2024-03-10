using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession_app
{
    public class TicketConcession
    {
        private const int TotalFare = 500;

        public string Name { get; set; }
        public int Age { get; set; }

        public void CalculateConcession()
        {
            if (Age <= 5)
            {
                Console.WriteLine($"Little Champs - Free Ticket | Name: {Name}, Age: {Age}");
            }
            else if (Age > 60)
            {
                double concessionAmount = 0.3 * TotalFare;
                double discountedFare = TotalFare - concessionAmount;
                Console.WriteLine($"Senior Citizen | Name: {Name}, Age: {Age}, Fare: {discountedFare}");
            }
            else
            {
                Console.WriteLine($"Ticket Booked | Name: {Name}, Age: {Age}, Fare: {TotalFare}");
            }
        }
    }
}
