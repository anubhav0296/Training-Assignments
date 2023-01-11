using System;
using System.Collections.Generic;
using System.Text;

namespace Q_3_Banking
{
    public class ICICIBank : Account
    {
        public ICICIBank() : base() {
            Console.WriteLine();
            Console.WriteLine("....ICICI Bank....");
            Console.WriteLine();
        }

        // This is a method of ICICIBank class that returns false, means when the balance is low it is true
        // Default true hai..
        public bool UnderBalance(int amount)
        {
            return false;
        }

        public bool BalanceZero(int amount)
        {
            if(balance <= 0 || balance - amount <= 0)
            {
                Console.WriteLine("Transaction cannot be continued as balance is insufficient/zero in Account");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
