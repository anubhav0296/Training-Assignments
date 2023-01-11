using System;

namespace Q_3_Banking
{
    
    class Program
    {
        static void Main(string[] args)
        {

            HDFCBank h = new HDFCBank();
            h.acceptDetails();
            h.Withdraw(200, h.UnderBalance, h.BalanceZero);
            h.Deposit(5000);
            h.Withdraw(900, h.UnderBalance, h.BalanceZero);
            
            ICICIBank i = new ICICIBank();
            i.acceptDetails();
            i.Withdraw(200, i.UnderBalance, i.BalanceZero);
            i.Deposit(5000);
            i.Withdraw(900, i.UnderBalance, i.BalanceZero);
        }
    }
}
