using System;
using System.IO;


namespace Q_3_Banking
{
    
    class Program
    {
        static void Main(string[] args)
        {
            HDFCBank h = new HDFCBank();
            h.acceptDetails("HDFC Bank");
            h.Withdraw(200, h.UnderBalance, h.BalanceZero);
            h.Deposit(5000);
            h.Withdraw(900, h.UnderBalance, h.BalanceZero);
            
            ICICIBank i = new ICICIBank();
            i.acceptDetails("ICICI Bank");
            i.Withdraw(200, i.UnderBalance, i.BalanceZero);
            i.Deposit(5000);
            i.Withdraw(900, i.UnderBalance, i.BalanceZero);


            // We are reading the output.txt in console
            StreamReader sr = new StreamReader(@"C:\Users\ANUBHASR\source\repos\Assignments_self\Output.txt");
            string line = "";
            while((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            sr.Close();
        }
    }
}
