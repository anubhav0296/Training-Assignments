using System;
using System.Collections.Generic;
using System.Text;

namespace Q_3_Banking
{
    // Made a delegate that will call methods of HDFC and ICICI bank 
    public delegate bool UnderBalance(int amount);
    public delegate bool BalanceZero(int amount);
    public class Account
    {

        public int accountNumber;
        public string customerName;
        public static int balance; // static iss liye kiya hai taaki derived class bhi isko use kr sake

        // Made a method that will accept details from user
        public void acceptDetails()
        {
            Console.WriteLine("Enter your Account Details: ");

            // Account No, Customer name, Balance -- these are taken as inputs
            Console.WriteLine("Enter Account Number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer Name: ");
            string custName = Console.ReadLine();
            
            Console.WriteLine("Enter Balance: ");
            int bal = Convert.ToInt32(Console.ReadLine());

            this.accountNumber = accNo;
            this.customerName = custName;
            balance = bal; // yha this nahi use hua, kyunki balance static hai
        }

        public Account() {
            Console.WriteLine($"The balance is: {balance}");
        }

        // Withdraw method is made and it will take (amount , and 2 delegate methods) 
        // It will check the condition of delegate methods and then go in if - condition
        public void Withdraw(int amount, UnderBalance ub, BalanceZero bz)
        {
            if (!ub(amount) && !bz(amount))
            {
                balance = balance - amount; // Deducts the amount from the balance
                Console.WriteLine($"Withdrawing {amount}"); // Display the amount and balance
                Console.WriteLine($"Available balance after Withdrawing {amount} is: {balance}");
            }
        }

        // Deposit method is made and it will deposit the amount adding it to balance and then it displays it
        public void Deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine($"Deposited {amount} in the Account");
            Console.WriteLine($"Available Balance: {balance}");
        }



    }
}
