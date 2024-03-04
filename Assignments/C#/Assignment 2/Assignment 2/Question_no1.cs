using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Accounts
    {
        // Data members
        public int accountNo;
        public string customerName;
        public string accountType;
        public char transactionType;
        public double amount;
        public double balance;

        // Constructor to initialize account details
        public Accounts(int accountNo, string customerName, string accountType)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.balance = 0; // Initial balance is 0
        }

        // Method (to credit amount to the account)
        public void Credit(double amount)
        {
            balance += amount;
        }

        // Method (to debit amount from the account)
        public void Debit(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        // Method (to update balance based on transaction type)
        public void UpdateBalance()
        {
            if (transactionType == 'D')
            {
                Credit(amount);
            }
            else if (transactionType == 'W')
            {
                Debit(amount);
            }
        }

        // Method (to display account data)
        public void ShowData()
        {
            Console.WriteLine("Account Number: " + accountNo);
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Account Type: " + accountType);
            Console.WriteLine("Transaction Type: " + transactionType);
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Balance: " + balance);
        }

        // Main
        static void Main(string[] args)
        {
            // Get account details from user input
            Console.WriteLine("Enter Account Number:");
            int accountNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer Name:");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter Account Type:");
            string accountType = Console.ReadLine();

            // Accounts object
            Accounts account = new Accounts(accountNo, customerName, accountType);

            // Get transaction details from user
            Console.WriteLine("Enter Transaction Type (D for Deposit, W for Withdrawal):");
            char transactionType = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Amount:");
            double amount = Convert.ToDouble(Console.ReadLine());

            // Set transaction details
            account.transactionType = transactionType;
            account.amount = amount;

            // Update balance based on transaction type
            account.UpdateBalance();

            // Display account data
            account.ShowData();

            Console.ReadLine();
        }
    }
}