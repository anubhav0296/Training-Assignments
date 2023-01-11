using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ass_6_7
{
    public delegate bool UnderBalance(double amount);
    public delegate bool BalanceZero(double amount);
    public class Account : User
    {
        public int acNumber;
        public string customerName;
        public double balance;

        public void acceptDetails(string bank_name)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\RAKERKAR\.Net-FullStack\C# Assignments\Assignment_6\Question3\output.txt", append: true);

            sw.WriteLine($"-----{bank_name}-----");
            Console.WriteLine("Enter Account Number: ");
            this.acNumber = Convert.ToInt32(Console.ReadLine());
            sw.WriteLine($"Account number: {acNumber}");

            Console.WriteLine("Enter Name: ");
            this.customerName = Console.ReadLine();
            sw.WriteLine($"Name: {customerName}");

            Console.WriteLine("Enter Balance: ");
            this.balance = Convert.ToDouble(Console.ReadLine());
            sw.WriteLine($"Balance: Rs.{balance}/-");

            Console.WriteLine("Account created");

            sw.Close();
        }
        public Account() { }
        public void Deposit(double amount)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\RAKERKAR\.Net-FullStack\C# Assignments\Assignment_6\Question3\output.txt", append: true);

            balance += amount;
            Console.WriteLine($"Deposited Rs.{amount}");
            sw.WriteLine($"Balance after depositing Rs.{amount}: Rs.{balance}/-");
            sw.Close();
        }

        public void Withdraw(double amount, UnderBalance ub, BalanceZero bz)
        {
            if (!bz(amount) && !ub(amount))
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\RAKERKAR\.Net-FullStack\C# Assignments\Assignment_6\Question3\output.txt", append: true);

                balance -= amount;
                Console.WriteLine($"Withdrawn Rs.{amount}");
                sw.WriteLine($"Balance after withdrawing Rs.{amount}: Rs.{balance}/-");
                sw.Close();
            }
        }
    }
}
