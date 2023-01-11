using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Q_3_Banking
{
    // Made a delegate that will call methods of HDFC and ICICI bank 
    public delegate bool UnderBalance(int amount);
    public delegate bool BalanceZero(int amount);
    public class Account : User
    {

        public int accountNumber;
        public string customerName;
        public static int balance; // static iss liye kiya hai taaki derived class bhi isko use kr sake

        // Made a method that will accept details from user
        public void acceptDetails(string bankName)
        {
            // We want to store this entire information in a output.txt file

            StreamWriter sw = new StreamWriter(@"C:\Users\ANUBHASR\source\repos\Assignments_self\Output.txt", append: true);


            Console.WriteLine($"....{bankName}....");

            Console.WriteLine("Enter your Account Details: ");

            // Account No, Customer name, Balance -- these are taken as inputs
            Console.WriteLine("Enter Account Number: ");
            this.accountNumber = Convert.ToInt32(Console.ReadLine());
            sw.WriteLine($"Account No - {accountNumber}");

            Console.WriteLine("Enter Customer Name: ");
            this.customerName = Console.ReadLine();
            sw.WriteLine($"Customer Name - {customerName}");
            
            Console.WriteLine("Enter Balance: ");
            balance = Convert.ToInt32(Console.ReadLine());
            sw.WriteLine($"Balance - {balance}");

            Console.WriteLine("Account is Created...");
            sw.Close();
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
                StreamWriter sw = new StreamWriter(@"C:\Users\ANUBHASR\source\repos\Assignments_self\Output.txt", append: true);
                balance = balance - amount; // Deducts the amount from the balance
                Console.WriteLine($"Withdrawing {amount}"); // Display the amount and balance
                Console.WriteLine($"Available balance after Withdrawing {amount} is: {balance}");
                sw.WriteLine($"Available balance after Withdrawing {amount} is: {balance}");
                sw.Close();
            }
        }

        // Deposit method is made and it will deposit the amount adding it to balance and then it displays it
        public void Deposit(int amount)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\ANUBHASR\source\repos\Assignments_self\Output.txt", append: true);
            balance = balance + amount;
            Console.WriteLine($"Deposited {amount} in the Account");
            Console.WriteLine($"Available Balance: {balance}");
            sw.WriteLine($"Deposited {amount} in the Account");
            sw.WriteLine($"Available Balance: {balance}");
            sw.Close();
        }
    }
}
