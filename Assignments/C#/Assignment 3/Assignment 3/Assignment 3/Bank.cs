////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace Assignment_3
////{
////class Bank_Account
////    { 
////        private double balance;
////        public Bank_Account(double initialBalance)
////        {
////            balance = initialBalance;
////        }

////        public void Deposit(double amount)

////        {

////            if (amount > 0)

////                balance += amount;

////            else

////                Console.WriteLine("Invalid deposit amount.");

////        }

////        public void Withdraw(double amount)

////        {

////            if (balance >= amount)

////                balance -= amount;

////            else

////                throw new InsufficientBalanceException("Insufficient balance for withdrawal.");

////        }

////        public double GetBalance()

////        {

////            return balance;

////        }

////    }

////    class InsufficientBalanceException : Exception

////    {

////        public InsufficientBalanceException(string message) : base(message)

////        {

////        }

////    }

////    class Bank

////    {

////        static void Main(string[] args)

////        {

////            try

////            {

////                Bank_Account myAccount = new Bank_Account(1000);

////                myAccount.Deposit(500);

////                myAccount.Withdraw(300);

////                Console.WriteLine($"Current balance: {myAccount.GetBalance()}");

////                myAccount.Withdraw(1500);

////            }

////            catch (InsufficientBalanceException ex)

////            {

////                Console.WriteLine("Error: {ex.Message}");

////            }

////            Console.Read();

////        }

////    }


////}


//////class Bank_Account

//////{

//////    private double balance;

//////    public Bank_Account(double initialBalance)

//////    {

//////        balance = initialBalance;

//////    }

//////    public void Deposit(double amount)

//////    {

//////        if (amount > 0)

//////            balance += amount;

//////        else

//////            Console.WriteLine("Invalid deposit amount.");

//////    }

//////    public void Withdraw(double amount)

//////    {

//////        if (balance >= amount)

//////            balance -= amount;

//////        else

//////            throw new InsufficientBalanceException("Insufficient balance for withdrawal.");

//////    }

//////    public double GetBalance()

//////    {

//////        return balance;

//////    }

//////}

//////class InsufficientBalanceException : Exception

//////{

//////    public InsufficientBalanceException(string message) : base(message)

//////    {

//////    }

//////}

//////class Bank

//////{

//////    static void Main(string[] args)

//////    {

//////        try

//////        {

//////            Bank_Account myAccount = new Bank_Account(1000);

//////            myAccount.Deposit(500);

//////            myAccount.Withdraw(300);

//////            Console.WriteLine($"Current balance: {myAccount.GetBalance()}");

//////            myAccount.Withdraw(1500);

//////        }

//////        catch (InsufficientBalanceException ex)

//////        {

//////            Console.WriteLine("Error: {ex.Message}");

//////        }

//////        Console.Read();

//////    }

//////}


//////}
/////

////----------------------------------------------------------


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment3
//{
//    public class ZeroBalance : Exception
//    {

//        public ZeroBalance(string message) : base(message) { }
//    }



//    public class Account
//    {
//        private double balance;

//        public void Deposit(double amount)
//        {
//            if (amount <= 0) throw new ArgumentException("Deposit must be greater than zero.");
//            balance += amount;
//            Console.WriteLine($"Deposited: ${amount}. Current Balance: ${balance}");
//        }



//        public void Withdraw(double amount)
//        {
//            if (amount <= 0) throw new ArgumentException("Withdrawal must be greater than zero.");

//            if (amount > balance) throw new ZeroBalance("Insufficient balance for your withdrawal.");


//            balance -= amount;

//            Console.WriteLine($"Withdrawn: ${amount}. Current Balance: ${balance}");
//        }

//        public double CheckBalance() => balance;
//    }


//    class Exceptionn
//    {
//        static void Main()
//        {
//            Account acc = new Account();

//            try
//            {
//                acc.Deposit(1000);
//                acc.Withdraw(500);
//                double balance = acc.CheckBalance();
//                Console.WriteLine($"Current Balance: ${balance}");
//            }
//            catch (ArgumentException ex) { Console.WriteLine($"Error: {ex.Message}"); }
//            catch (ZeroBalance ex) { Console.WriteLine($"Error: {ex.Message}"); }
//            catch (Exception ex) { Console.WriteLine($"Unexpected Error occured: {ex.Message}"); }
//            Console.ReadKey();
//        }

//    }
//}


//--

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