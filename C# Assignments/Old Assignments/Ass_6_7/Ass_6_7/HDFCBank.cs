using System;
using System.Collections.Generic;
using System.Text;

namespace Ass_6_7
{
    public class HDFCBank : Account
    {
        public HDFCBank() : base() { }


        public bool BalanceZero(double amount) { return false; }
        public bool UnderBalance(double amount)
        {
            if (balance < 1000 || balance - amount < 1000)
            {
                Console.WriteLine("Transaction cannot be continued below specified limit of Rs.1000 \n");
                Console.WriteLine($"Max amount that can be withdrawn: Rs.{balance - 1000}");
                return true;
            }
            else
                return false;
        }
    }
}
