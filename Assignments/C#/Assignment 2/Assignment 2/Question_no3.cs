using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class SaleDetails
    {
        // Data members
        public int salesNo;
        public int productNo;
        public double price;
        public DateTime dateOfSale;
        public int qty;
        public double totalAmount;

        // Constructor to initialize sales details
        public SaleDetails(int salesNo, int productNo, double price, int qty, DateTime dateOfSale)
        {
            this.salesNo = salesNo;
            this.productNo = productNo;
            this.price = price;
            this.qty = qty;
            this.dateOfSale = dateOfSale;
        }

        // Method to calculate total amount
        public void Sales()
        {
            totalAmount = qty * price;
        }

        // Method to display sales data
        public void ShowData()
        {
            Console.WriteLine("Sales No: " + salesNo);
            Console.WriteLine("Product No: " + productNo);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Quantity: " + qty);
            Console.WriteLine("Date of Sale: " + dateOfSale.ToShortDateString());
            Console.WriteLine("Total Amount: " + totalAmount);
        }

        // Main
        static void Main(string[] args)
        {
            // Get sales details from user input
            Console.WriteLine("Enter Sales No:");
            int salesNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product No:");
            int productNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Price:");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Quantity:");
            int qty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Date of Sale (YYYY-MM-DD):");
            DateTime dateOfSale = DateTime.Parse(Console.ReadLine());

            // Create a new SaleDetails object
            SaleDetails sale = new SaleDetails(salesNo, productNo, price, qty, dateOfSale);

            // Calculate total amount
            sale.Sales();

            // Display sales data
            sale.ShowData();

            Console.ReadLine();
        }
    }
}