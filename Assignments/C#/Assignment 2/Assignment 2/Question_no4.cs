using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Customer
    {
        // Data members
        public int customerId;
        public string name;
        public int age;
        public string phone;
        public string city;

        // Constructor with no arguments
        public Customer()
        {
            Console.WriteLine("Default constructor called.");
        }

        // Constructor with all information
        public Customer(int customerId, string name, int age, string phone, string city)
        {
            this.customerId = customerId;
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.city = city;
        }

        // Method to display customer details
        public void DisplayCustomer()
        {
            Console.WriteLine("Customer ID: " + customerId);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("City: " + city);
        }

        // Destructor
        ~Customer()
        {
            Console.WriteLine("Destructor called.");
        }

        // Static method to display customer details without creating an object
        public static void DisplayCustomer(int customerId, string name, int age, string phone, string city)
        {
            Console.WriteLine("Customer ID: " + customerId);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("City: " + city);
        }

        // Main
        static void Main(string[] args)
        {
            // Get customer details from user input
            Console.WriteLine("Enter Customer ID:");
            int customerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone:");
            string phone = Console.ReadLine();

            Console.WriteLine("Enter City:");
            string city = Console.ReadLine();

            // Create a new Customer object using constructor with all information
            Customer customer1 = new Customer(customerId, name, age, phone, city);

            // Display customer details using instance method
            //customer1.DisplayCustomer();

            // Call static method to display customer details without creating an object
            Customer.DisplayCustomer(customerId, name, age, phone, city);

            Console.ReadLine();
        }
    }
}