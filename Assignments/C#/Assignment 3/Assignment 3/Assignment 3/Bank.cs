using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class ZeroBal : Exception
    {

        public ZeroBal(string msg) : base(msg) { }
    }


    public class Account
    {
        private double balance;

        public void Deposit(double amount)
        {
            if (amount <= 0) throw new ArgumentException("Deposit must be greater than zero.");
            balance += amount;
            Console.WriteLine($"Deposited in your Account: {amount}");
            Console.WriteLine($"Now your Current Balance is: {balance}");
        }


        public void Withdraw(double amount)
        {
            if (amount <= 0) throw new ArgumentException("Withdrawal must be greater than zero.");

            if (amount > balance) throw new ZeroBal("Insufficient balance for your withdrawal.");


            balance -= amount;

            Console.WriteLine($"Withdrawn from your Account: {amount}");
            Console.WriteLine($"Now your Current Balance is : {balance}");
        }

        public double CheckBalance() => balance;
    }
    class Banking
    {
        static void Main()
        {
            Account acc = new Account();

            try
            {
                acc.Deposit(1000);
                acc.Withdraw(500);
                double balance = acc.CheckBalance();
                Console.WriteLine($"Your Total Balance in your account: {balance}");
            }
            catch (ArgumentException ex) { Console.WriteLine($"Error: {ex.Message}"); }
            catch (ZeroBal ex) { Console.WriteLine($"Error: {ex.Message}"); }
            catch (Exception ex) { Console.WriteLine($"Unexpected Error occured: {ex.Message}"); }
            Console.ReadKey();
        }


    }
}